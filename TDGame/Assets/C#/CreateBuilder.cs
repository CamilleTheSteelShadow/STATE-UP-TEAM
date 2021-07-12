/*****************************************************

*　　功能　　　　　　确定可建造防御塔区域

*　　作者　　　　　　伍迎

*　　时间　　　　　　2021.07.10

*　　

*　　修改说明　　　　.......

*　　。。。

*******************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBuilder : MonoBehaviour
{

    public GameObject builder;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(builder,transform).transform.localPosition = new Vector2(217,1);
        Instantiate(builder,transform).transform.localPosition = new Vector2(274,-238);
        Instantiate(builder,transform).transform.localPosition = new Vector2(154,-123);
        Instantiate(builder,transform).transform.localPosition = new Vector2(-25,-238);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
