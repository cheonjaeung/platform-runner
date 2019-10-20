using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Player 제어 스크립트
 */
public class Player : MonoBehaviour
{
    public GameManager manager;
    public Rigidbody2D rigid;
    public SpriteRenderer sprite;
    public PlayerAnimation animationScript;

    //이동 제어 변수
    private int moveDir;
    private bool isJumping;
    private bool isAir;

    //이동 수치 변수
    private float speed;
    private float jumpPower;

    private void Start()
    {
        animationScript = GetComponent<PlayerAnimation>();

        moveDir = 0;
        isJumping = false;
        isAir = true;

        speed = 5.0f;
        jumpPower = 500.0f;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
            LeftButtonDown();
        if (Input.GetKey(KeyCode.RightArrow))
            RightButtonDown();
        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
            MoveButtonUp();
        if (Input.GetKey(KeyCode.Space))
            JumpButton();
    }

    private void FixedUpdate()
    {
        //이동 제어변수에 따라 이동
        //방향에 따라 스프라이트를 x방향으로 뒤집기
        if(moveDir != 0)
        {
            transform.Translate(Vector2.right * moveDir * speed * Time.deltaTime);
            animationScript.SetAnimationRun(true);
            if(moveDir == -1)
            {
                sprite.flipX = true;
            }
            else if(moveDir == 1)
            {
                sprite.flipX = false;
            }
        }

        //점프제어변수에 따라 점프
        if (isJumping)
        {
            rigid.AddForce(Vector2.up * jumpPower * Time.deltaTime, ForceMode2D.Impulse);
            animationScript.SetAnimationJumpStart();
            isJumping = false;
        }
    }

    //땅과 충돌시 점프 초기화
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //충돌체의 태그를 받아옴
        string tag = collision.transform.tag;

        if(tag == "Ground")
        {
            animationScript.SetAnimationJumpStop();
            isAir = false;
        }
    }

    //적과 충돌시 게임 재시작
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //충돌체의 태그를 받아옴
        string tag = collision.transform.tag;

        if (tag == "Enemy")
        {
            manager.RestartScene();
        }
    }

    /* UI의 이동 버튼 컨트롤 */
    public void LeftButtonDown()
    {
        moveDir = -1;
    }

    public void RightButtonDown()
    {
        moveDir = 1;
    }

    public void MoveButtonUp()
    {
        rigid.velocity = new Vector2(0, rigid.velocity.y);
        animationScript.SetAnimationRun(false);
        moveDir = 0;
    }

    public void JumpButton()
    {
        //공중에 있지 않을 때만 점프 가능
        if (!isAir)
        {
            isAir = true;
            isJumping = true;
        }
        else
        {
            return;
        }
    }
}
