using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/*
 * Stage Scene의 UI 스크립트
 * 스테이지 클리어 여부에 따라 스테이지 잠금 해제
 */
public class StageUIManager : MonoBehaviour
{
    public GameManager manager;

    //스테이지 버튼들
    public GameObject button1_1;
    public GameObject button1_2;
    public GameObject button1_3;
    public GameObject button1_4;
    public GameObject button2_1;
    public GameObject button2_2;
    public GameObject button2_3;
    public GameObject button2_4;
    public GameObject button3_1;
    public GameObject button3_2;
    public GameObject button3_3;
    public GameObject button3_4;
    public GameObject button4_1;
    public GameObject button4_2;
    public GameObject button4_3;
    public GameObject button4_4;

    //열린 버튼 스프라이트
    

    //잠긴 버튼 스프라이트

    private void Start()
    {
        
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
    }

    //봄 스테이지 버튼
    public void Spring1button()
    {
        SceneManager.LoadScene("Spring_1");
    }
    public void Spring2button()
    {
        SceneManager.LoadScene("Spring_2");
    }
    public void Spring3button()
    {
        //SceneManager.LoadScene("Spring_3");
    }
    public void Spring4button()
    {
        //SceneManager.LoadScene("Spring_4");
    }

    //여름 스테이지 버튼
    public void Summer1Button()
    {
        //SceneManager.LoadScene("Summer_1");
    }
    public void Summer2Button()
    {
        //SceneManager.LoadScene("Summer_2");
    }
    public void Summer3Button()
    {
        //SceneManager.LoadScene("Summer_3");
    }
    public void Summer4Button()
    {
        //SceneManager.LoadScene("Summer_4");
    }

    //가을 스테이지 버튼
    public void Autumn1Button()
    {
        //SceneManager.LoadScene("Autumn_1");
    }
    public void Autumn2Button()
    {
        //SceneManager.LoadScene("Autumn_3");
    }
    public void Autumn3Button()
    {
        //SceneManager.LoadScene("Autumn_3");
    }
    public void Autumn4Button()
    {
        //SceneManager.LoadScene("Autumn_4");
    }

    //겨울 스테이지 버튼
    public void Winter1Button()
    {
        //SceneManager.LoadScene("Winter_1");
    }
    public void Winter2Button()
    {
        //SceneManager.LoadScene("Winter_2");
    }
    public void Winter3Button()
    {
        //SceneManager.LoadScene("Winter_3");
    }
    public void Winter4Button()
    {
        //SceneManager.LoadScene("Winter_4");
    }
}
