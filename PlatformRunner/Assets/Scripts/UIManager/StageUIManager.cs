using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Stage Scene의 UI 스크립트
 */
public class StageUIManager : MonoBehaviour
{
    public GameManager manager;
    public GameObject SummerButton;
    public GameObject AutumnButton;
    public GameObject WinterButton;

    private void Start()
    {
        SummerButton.SetActive(false);
        AutumnButton.SetActive(false);
        WinterButton.SetActive(false);
    }

    private void Update()
    {
        //뒤로가기 버튼 입력시 QuitButton과 같은 행동
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            BackButton();
        }
    }

    //뒤로가기 버튼
    public void BackButton()
    {
        SceneManager.LoadScene("Title");
        manager.SetCurrentSceneName("Title");
    }

    //봄 스테이지 버튼
    public void Springbutton()
    {
        SceneManager.LoadScene("Spring1");
        manager.SetCurrentSceneName("Spring1");
    }
}
