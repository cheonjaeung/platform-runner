using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Title Scene의 UI 스크립트
 */
public class TitleUIManager : MonoBehaviour
{
    public GameObject panel;
    public GameManager manager;

    private void Start()
    {
        panel.SetActive(false);
    }

    private void Update()
    {
        //뒤로가기 버튼 입력시 QuitButton과 같은 행동
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            QuitButton();
        }
    }

    //게임시작 버튼
    public void StartButton()
    {
        SceneManager.LoadScene("Stage");
    }

    //게임종료 버튼
    public void QuitButton()
    {
        panel.SetActive(true);
    }

    //게임종료 Yes 버튼
    public void YesButton()
    {
        manager.QuitGame();
    }

    //게임종료 No 버튼
    public void NoButton()
    {
        panel.SetActive(false);
    }
}
