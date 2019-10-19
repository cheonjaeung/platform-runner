using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Player 애니메이션 제어 스크립트
 */
public class PlayerAnimation : MonoBehaviour
{
    private Rigidbody2D rigid;
    private Animator animator;

    //점프 애니메이션 제어 변수
    private bool isJumping;

    private void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();
    }

    private void Update()
    {
        //점프중일 때에만 점프 애니메이션 작동
        if (isJumping)
        {
            float velocity = rigid.velocity.y;
            if(velocity > 0)
            {
                animator.SetInteger("jumpDir", 1);
            }
            else if(velocity <= 0)
            {
                animator.SetInteger("jumpDir", -1);
            }
        }
    }

    //달리기 애니메이션 설정 함수
    public void SetAnimationRun(bool value)
    {
        animator.SetBool("isRunning", value);
    }

    //점프 애니메이션 시작
    public void SetAnimationJumpStart()
    {
        isJumping = true;
    }

    //점프 애니메이션 중지
    public void SetAnimationJumpStop()
    {
        animator.SetInteger("jumpDir", 0);
        isJumping = false;
    }
}
