using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Player 애니메이션 제어 스크립트
 */
public class PlayerAnimation : MonoBehaviour
{
    public Rigidbody2D rigid;
    public Animator animator;

    private void Update()
    {
        //플레이어의 y축 이동량이 일정수치 이상일 경우 애니메이션 적용
        if(rigid.velocity.y < -0.01 || rigid.velocity.y > 0.01)
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

    //달리기 애니메이션 설정 함수
    public void SetAnimationRun(bool value)
    {
        animator.SetBool("isRunning", value);
    }
}
