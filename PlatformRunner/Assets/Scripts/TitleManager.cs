using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Title Scene 매니저 스크립트
 * 게임의 화면설정과 씬 내의 UI 행동 정의
 */
public class TitleManager : MonoBehaviour
{
    private void Awake()
    {
        //화면 해상도를 고정시키고 게임 도중 화면이 꺼지지 않도록 설정
        Screen.SetResolution(1920, 1080, true);
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }

    //Start 버튼의 행동
    public void StartButton()
    {
        //Stage Scene 로드
        SceneManager.LoadScene("Stage");
    }

    //Quit 버튼의 행동
    public void QuitButton()
    {
        //게임 종료
        Application.Quit();
    }
}
