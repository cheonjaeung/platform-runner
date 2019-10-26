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

    //잠긴 버튼 스프라이트
    public Sprite springLock;
    public Sprite summerLock;
    public Sprite autumnLock;
    public Sprite winterLock;

    private bool[] stageLock;

    private void Start()
    {
        for(int i = 4; i < 16; i++)
        {
            ButtonLock(i);
        }
    }

    private void Update()
    {
        //뒤로가기 버튼 입력시 QuitButton과 같은 행동
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            BackButton();
        }
    }

    //버튼 이미지를 잠금상태로 바꾸는 함수
    //스테이지 씬 로드시 잠긴 스테이지를 표시하기 위해 사용
    private void ButtonLock(int index)
    {
        switch (index)
        {
            case 0:
                button1_1.GetComponent<Image>().sprite = springLock;
                break;
            case 1:
                button1_2.GetComponent<Image>().sprite = springLock;
                break;
            case 2:
                button1_3.GetComponent<Image>().sprite = springLock;
                break;
            case 3:
                button1_4.GetComponent<Image>().sprite = springLock;
                break;
        }
    }
    
    //뒤로가기 버튼
    public void BackButton()
    {
        SceneManager.LoadScene("Title");
    }

    //스테이지 버튼
    public void Stage1Button()
    {
        SceneManager.LoadScene("Stage1_1");
    }
    public void Stage2Button()
    {
        SceneManager.LoadScene("Stage1_2");
    }
    public void Stage3Button()
    {
        SceneManager.LoadScene("Stage1_3");
    }
    public void Stage4Button()
    {
        SceneManager.LoadScene("Stage1_4");
    }
}
