using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 톱의 움직임을 정의하는 스크립트
 */
public class SawMove : MonoBehaviour
{
    //움직일 방향
    public bool isHorizontal;
    //속도
    public float speed;
    //현재 이동 방향
    private int moveDir;
    //톱의 회전을 위해 스프라이트 컴포넌트 사용
    private SpriteRenderer sprite;

    private void Start()
    {
        moveDir = 1;
        sprite = gameObject.GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        //가로로 움직이는 경우
        if (isHorizontal)
        {
            transform.Translate(Vector2.right * moveDir * speed * Time.deltaTime);
        }
        //세로로 움직이는 경우
        else
        {
            transform.Translate(Vector2.down * moveDir * speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //땅에 부딫히면 방향을 반대로 전환
        string tag = collision.transform.tag;
        if (tag == "Ground")
        {
            moveDir = moveDir * -1;
        }
    }
}
