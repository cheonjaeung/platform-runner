using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 배경이 플레이어를 따라가게 하는 스크립트
 */
public class BackgroundMove : MonoBehaviour
{
    //게임매니저
    public GameManager manager;
    //따라갈 플레이어
    public GameObject player;

    //배경이 0, 0, 10에 위치하는지 여부 변수
    private bool isOnPosition;

    private void Start()
    {
        isOnPosition = true;
    }

    private void LateUpdate()
    {
        //Title Scene이나 Stage Scene이 아닌 경우에만 배경이 플레이어를 따라가게 설정
        if(manager.GetCurrentSceneName() != "title" || manager.GetCurrentSceneName() != "Stage")
        {
            //플레이어의 위치로 카메라의 위치 업데이트
            float newX = player.transform.position.x;
            float newY = player.transform.position.y;

            transform.position = new Vector3(newX, newY, 10);
            isOnPosition = false;
        }
        else
        {
            //배경이 0, 0, 10에 없으면
            if (!isOnPosition)
            {
                transform.position = new Vector3(0, 0, 10);
            }
        }
    }
}
