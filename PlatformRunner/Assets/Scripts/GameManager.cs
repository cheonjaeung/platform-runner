using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * GameManager 스크립트
 * 게임의 화면설정과 씬 내의 UI 행동 정의
 */
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    //게임 종료를 다시 묻는 패널
    public GameObject QuitPanel;

    private void Awake()
    {
        //게임매니저 스크립트는 싱글톤으로 만들어 게임 전체에서 사용
        if (instance == null)
            instance = this;
        //씬을 이동해도 파괴되지 않도록 설정
        DontDestroyOnLoad(instance);

        //화면 해상도를 고정시키고 게임 도중 화면이 꺼지지 않도록 설정
        Screen.SetResolution(1920, 1080, true);
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        //QuitPanel이 평소에 보이지 않도록 설정
        QuitPanel.SetActive(false);
    }

    private void Update()
    {
        //뒤로가기 키 입력시 QuitButton과 같은 행동 취하기
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            QuitButton();
        }
    }

    /* 게임종료 관련 UI 컨트롤 */
    //QuitButton의 행동
    public void QuitButton()
    {
        //Panel을 띄움
        QuitPanel.SetActive(true);
    }

    //YesButton의 행동
    public void YesButton()
    {
        //게임 종료
        Application.Quit();
    }

    //NoButton의 행동
    public void NoButton()
    {
        //Panel을 숨김
        QuitPanel.SetActive(false);
    }

    /* Title Scene의 UI 컨트롤 */
    //StartButton의 행동
    public void StartButton()
    {
        //Stage Scene 로드
        SceneManager.LoadScene("Stage");
    }
}