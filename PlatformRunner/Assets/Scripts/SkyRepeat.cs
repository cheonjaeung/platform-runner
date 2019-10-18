using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 배경 하늘이 자동으로 스크롤되게 하는 스크립트
 */
public class SkyRepeat : MonoBehaviour
{
    //스크롤 속도
    private float speed;
    //Material
    private Material material;

    private void Start()
    {
        speed = 0.05f;
        material = gameObject.GetComponent<Renderer>().material;
    }

    private void Update()
    {
        //현재 Material의 offset을 받아와 속도를 곱한 뒤 Material에 적용한다
        float newOffset = material.mainTextureOffset.x + speed * Time.deltaTime;
        material.mainTextureOffset = new Vector2(newOffset, material.mainTextureOffset.y);
    }
}
