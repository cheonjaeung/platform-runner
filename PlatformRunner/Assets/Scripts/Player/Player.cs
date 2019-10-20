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
    public Animator animator;

    //이동 제어 변수
    private int moveDir;
    private bool isJumping;
    private bool isAir;

    //이동 수치 변수
    private float speed;
    private float jumpPower;

    private void Start()
    {
        moveDir = 0;
        isJumping = false;
        isAir = true;

        speed = 5.0f;
        jumpPower = 500.0f;
    }

    private void Update()
    {
        //유니티 에디터(PC)에서 테스트하기 위해 추가
        if (Input.GetKey(KeyCode.LeftArrow))
            LeftButtonDown();
        if (Input.GetKey(KeyCode.RightArrow))
            RightButtonDown();
        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
            MoveButtonUp();
        if (Input.GetKeyDown(KeyCode.Space))
            JumpButton();

        //플레이어의 y축 이동량이 일정수치 이상일 경우 점프 애니메이션 적용
        if (rigid.velocity.y < -0.01 || rigid.velocity.y > 0.01)
        {
            float velocity = rigid.velocity.y;
            if (velocity > 0)
            {
                animator.SetInteger("jumpDir", 1);
            }
            else if (velocity <= 0)
            {
                animator.SetInteger("jumpDir", -1);
            }
        }
        else
        {
            animator.SetInteger("jumpDir", 0);
        }
    }

    private void FixedUpdate()
    {
        //이동 제어변수에 따라 이동
        //방향에 따라 스프라이트를 x방향으로 뒤집기
        if(moveDir != 0)
        {
            transform.Translate(Vector2.right * moveDir * speed * Time.deltaTime);
            animator.SetBool("isRunning", true);
            if (moveDir == -1)
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
            isJumping = false;
        }
    }

    //땅과 충돌시 점프 초기화
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isAir = false;
        isJumping = false;
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
        animator.SetBool("isRunning", false);
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
