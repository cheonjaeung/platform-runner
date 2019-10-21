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
    private string currentSceneName;
    
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
        //현재 활성화된 씬 이름과 변수가 같지 않으면 변수에 이름 대입
        if(currentSceneName != SceneManager.GetActiveScene().name)
        {
            currentSceneName = SceneManager.GetActiveScene().name;
        }
    }

    //게임 시작시 작동하는 함수
    public void StartGame()
    {
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

    //씬 재시작시 작동하는 함수
    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    //게임 종료시 작동하는 함수
    public void QuitGame()
    {
        //게임 종료
        Application.Quit();
    }

    //현재 씬 이름 변수를 가져오는 함수
    public string GetCurrentSceneName()
    {
        return currentSceneName;
    }
}
