using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 하늘이 자동으로 움직이게 하는 스크립트
 */
public class SkyRepeat : MonoBehaviour
{
    //스크롤 속도
    public float speed;
    //Material
    private Material material;

    private void Start()
    {
        material = gameObject.GetComponent<Renderer>().material;
    }

    private void Update()
    {
        //현재 offset을 가져와 속도만큼 더한 뒤 다시 적용
        Vector2 newOffset = new Vector2(material.mainTextureOffset.x + speed * Time.deltaTime, 0);
        material.mainTextureOffset = newOffset;
    }
}
