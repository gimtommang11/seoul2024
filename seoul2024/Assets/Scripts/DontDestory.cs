using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestory : MonoBehaviour
{

     void Awake()        // 유니티에서 제공하는 함수
    {
        //DontDestroyOnLoad(GameObject.Find("DontDestroy"));
        DontDestroyOnLoad(this.gameObject);
    }
}
