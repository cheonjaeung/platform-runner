using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMaker : MonoBehaviour
{
    //생성할 구름 오브젝트
    public GameObject Cloud1;
    public GameObject Cloud2;
    //구름 생성 가능 여부 변수
    private bool canMake;

    private void Start()
    {
        //시작할때 랜덤 위치에 구름 3개 생성
        for (int i = 0; i < 3; i++)
        {
            float randomX = Random.Range(-7.0f, 7.0f);
            float randomY = Random.Range(0.0f, 4.0f);
            int randomCloud = Random.Range(1, 3);

            Vector3 position = new Vector3(randomX, randomY, 3);

            if (randomCloud == 1)
                Instantiate(Cloud1, position, transform.rotation);
            if (randomCloud == 2)
                Instantiate(Cloud2, position, transform.rotation);
        }
            canMake = true;
    }

    private void Update()
    {
        if(canMake)
        {
            //bool변수가 참일 때만 구름을 만듬
            StartCoroutine(CloudMakingDelay());
        }
    }

    private IEnumerator CloudMakingDelay()
    {
        canMake = false;
        //난수를 사용해 랜덤 시간마다 랜덤 높이에서 랜덤 구름 생성
        float randomTime = Random.Range(10.0f, 30.0f);
        float randomY = Random.Range(0.0f, 4.0f);
        int randomCloud = Random.Range(1, 3);

        Vector3 position = new Vector3(8, randomY, 3);

        if (randomCloud == 1)
            Instantiate(Cloud1, position, transform.rotation);
        if (randomCloud == 2)
            Instantiate(Cloud2, position, transform.rotation);

        //랜덤 시간만큼 대기
        yield return new WaitForSeconds(randomTime);
        canMake = true;
    }
}
