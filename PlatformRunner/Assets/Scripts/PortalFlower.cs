using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * 포탈 꽃의 기능을 정의하는 스크립트
 */
public class PortalFlower : MonoBehaviour
{
    public GameManager manager;

    //충돌시
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //태그가 플레이어인 경우에만 작동
        string tag = collision.transform.tag;
        if(tag == "Player")
        {
            //현재 열려있는 씬의 빌드 인덱스를 받아옴
            int index = SceneManager.GetActiveScene().buildIndex;
            //그 다음 인덱스의 씬 로드
            SceneManager.LoadScene(index + 1);
            //이를 위해서 빌드 인덱스를 순서대로 맞출 필요가 있음
        }
    }
}
