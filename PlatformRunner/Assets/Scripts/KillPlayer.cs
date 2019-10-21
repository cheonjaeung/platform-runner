using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 플레이어와 충돌시 게임을 재시작하는 스크립트(적에게 사용)
 */
public class KillPlayer : MonoBehaviour
{
    public GameManager manager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //충돌체의 태그를 받아옴
        string tag = collision.transform.tag;
        if (tag == "Player")
        {
            manager.RestartScene();
        }
    }
}
