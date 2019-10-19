using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * StageScene 관리 스크립트
 * UI 컨트롤
 */
public class StageManager : MonoBehaviour
{
    private void Update()
    {
        //뒤로가기 키 입력시 QuitButton과 같은 행동 취하기
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            QuitButton();
        }
    }

    /* StageScene UI 컨트롤 */
    //QuitButton
    public void QuitButton()
    {
        //TitleScene으로 돌아감
        SceneManager.LoadScene("Title");
    }

    //SpringButton
    public void Springbutton()
    {
        //SpringScene으로 이동
        SceneManager.LoadScene("Spring");
    }

    //SummerButton
    public void SummerButton()
    {

    }

    //AutumnButton
    public void AutumnButton()
    {

    }

    //WinterButton
    public void WinterButon()
    {

    }
}
