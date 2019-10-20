using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 카메라가 플레이어를 따라가게 만드는 스크립트
 */
public class CameraMove : MonoBehaviour
{
    //따라갈 플레이어
    public GameObject player;

    private void LateUpdate()
    {
        //플레이어의 위치로 카메라의 위치 업데이트
        float newX = player.transform.position.x;
        float newY = player.transform.position.y;

        transform.position = new Vector3(newX, newY, -10);
    }
}
