/*****************************************************

*　　功能　　　　　　子弹MagicBullet
*　　作者　　　　　　伍迎

*　　时间　　　　　　2021.07.15

*　　

*　　修改说明　　　　.......

*　　。。。

*******************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicBullet : MonoBehaviour
{
    public int harm=1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void DestroyBullet(){
        MonoBehaviour.Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
