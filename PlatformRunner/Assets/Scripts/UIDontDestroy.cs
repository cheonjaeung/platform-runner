using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * canvas 오브젝트가 게임 진행하는 동안 파괴되지 않도록 하는 스크립트
 */
public class UIDontDestroy : MonoBehaviour
{
    public static UIDontDestroy instance;

    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(instance);
    }
}
