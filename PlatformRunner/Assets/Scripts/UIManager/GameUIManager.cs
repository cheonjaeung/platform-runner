using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Spring Scene의 UI 스크립트
 */
public class GameUIManager : MonoBehaviour
{
    public GameManager manager;
    public GameObject panel;

    private void Start()
    {
        panel.SetActive(false);
    }

    private void Update()
    {
        //뒤로가기 버튼 입력시 퍼즈 버튼과 같은 행동
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseButton();
        }
    }

    //퍼즈 버튼
    public void PauseButton()
    {
        panel.SetActive(true);
        manager.PauseGameStart();
    }

    //퍼즈 해제 버튼
    public void PauseEndButton()
    {
        panel.SetActive(false);
        manager.PauseGameEnd();
    }

    //재시작 버튼
    public void RestartButton()
    {
        manager.RestartScene();
        manager.PauseGameEnd();
    }

    //뒤로가기 버튼
    public void BackButton()
    {
        SceneManager.LoadScene("Stage");
        manager.SetCurrentSceneName("Stage");
        manager.PauseGameEnd();
    }
}
