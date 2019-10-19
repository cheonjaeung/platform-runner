using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * TitleScene 관리 스크립트
 * 게임 화면설정 및 UI 컨트롤
 */
public class TitleManager : MonoBehaviour
{
    public GameObject QuitPanel;

    private void Awake()
    {
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

    /* QuitPanel UI 컨트롤 */
    //QuitButton
    public void QuitButton()
    {
        //Panel을 띄움
        QuitPanel.SetActive(true);
    }

    //YesButton
    public void YesButton()
    {
        //게임 종료
        Application.Quit();
    }

    //NoButton
    public void NoButton()
    {
        //Panel을 숨김
        QuitPanel.SetActive(false);
    }

    /* TitleScene UI 컨트롤 */
    //StartButton
    public void StartButton()
    {
        //Stage Scene 로드
        SceneManager.LoadScene("Stage");
    }
}
