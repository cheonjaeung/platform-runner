using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * 게임 관리 스크립트
 */
public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    //게임 진행 관리 변수
    private bool isGaming;  //게임 진행여부
    private string curruntSceneName;    //현재 씬 이름

    //UI 오브젝트
    public GameObject titlePanel;
    public GameObject quitPanel;
    public GameObject stagePanel;
    
    private void Awake()
    {
        //싱글톤을 사용해 게임 전체에 하나밖에 생성할수 없도록 만듬
        instance = this;
        //씬을 이동해도 오브젝트가 파괴되지 않도록
        DontDestroyOnLoad(instance);

        //스크린 해상도 설정 및 화면이 게임도중 꺼지지 않도록 설정
        Screen.SetResolution(1920, 1080, true);
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }

    private void Start()
    {
        StartGame();
    }

    private void Update()
    {
        //뒤로가기 버튼 입력시
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //현재 Scene에 따라서 다르게 행동
            switch (curruntSceneName)
            {
                //Title Scene에서는 게임종료 패널이 뜨도록
                case "Title":
                    QuitButton();
                    break;
                default:
                    break;
            }
        }
    }



    /*
     * --------------------------------------------------
     * 게임 진행 관리 함수
     */
    //게임 시작시 작동하는 함수
    public void StartGame()
    {
        //변수 초기화
        isGaming = true;
        curruntSceneName = "Title";

        //UI 활성화 비활성화 설정
        quitPanel.SetActive(false);
        stagePanel.SetActive(false);
    }

    //게임 중지시 작동하는 함수
    public void PauseGameStart()
    {
        //게임 시간 중지
        Time.timeScale = 0;
    }

    //게임 중지상태 해제시 작동하는 함수
    public void PauseGameEnd()
    {
        //게임 시간 중지 해제
        Time.timeScale = 1;
    }

    //게임 종료시 작동하는 함수
    public void QuitGame()
    {
        //게임 종료
        Application.Quit();
    }

    //게임 씬 이동 함수
    public void MoveScene(string sceneName)
    {
        //해당 씬을 로딩하고 현재 씬 이름을 변경
        SceneManager.LoadScene(sceneName);
        curruntSceneName = sceneName;

        //해당 씬에 맞춰서 UI 활성화/비활성화
        switch (sceneName)
        {
            case "Title":
                titlePanel.SetActive(true);
                quitPanel.SetActive(false);
                stagePanel.SetActive(false);
                break;
            case "Stage":
                titlePanel.SetActive(false);
                quitPanel.SetActive(false);
                stagePanel.SetActive(true);
                break;
        }
    }
    //--------------------------------------------------



    /*
     * --------------------------------------------------
     * Title UI에서 작동하는 함수
     */
    //게임시작버튼
    public void StartButton()
    {
        //Stage Scene으로 이동
        MoveScene("Stage");
    }

    //뒤로가기 버튼
    public void QuitButton()
    {
        quitPanel.SetActive(true);
    }
    //--------------------------------------------------



    /*
     * --------------------------------------------------
     * Quit UI에서 작동하는 함수
     */
    //예 버튼
    public void QuitYesButton()
    {
        QuitGame();
    }
    //아니오 버튼
    public void QuitNoButton()
    {
        quitPanel.SetActive(false);
    }
    //--------------------------------------------------
}
