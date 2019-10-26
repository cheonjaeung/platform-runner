using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * 목표 꽃의 행동을 정의하는 스크립트
 */
public class GoalFlower : MonoBehaviour
{
    //충돌시
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //태그가 플레이어인 경우에만 작동
        string tag = collision.transform.tag;
        if (tag == "Player")
        {
            SceneManager.LoadScene("Stage");
        }
    }
}
