using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 구름 이동 스크립트
 */
public class CloudMove : MonoBehaviour
{
    //구름의 이동속도
    private float speed;

    private void Start()
    {
        speed = 0.2f;
    }

    private void Update()
    {
        //생성된 순간부터 계속 왼쪽으로 속도에 따라 이동
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        //만약 x좌표가 -8보다 작아지면 오브젝트 파괴
        if(transform.position.x <= -8)
        {
            Destroy(gameObject);
        }
    }
}
