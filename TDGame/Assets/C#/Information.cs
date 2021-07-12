/*****************************************************

*　　功能　　　　　　更新关卡中玩家生命值、金币数

*　　作者　　　　　　伍迎

*　　时间　　　　　　2021.07.10

*　　

*　　修改说明　　　　.......

*　　。。。

*******************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Information : MonoBehaviour
{
    public Text lifeNum;
    public Text goldNum;

    int life=0;
    int gold=0;
  
    // Start is called before the first frame update
    void Start()
    {
        Scene scene = SceneManager.GetActiveScene ();

        switch(scene.name){
            case "Level1":
            life=10;
            gold=100;
            lifeNum.text=""+life;
            goldNum.text=""+gold;
            break;

        }
        Debug.Log(gold);
        Debug.Log(goldNum.text);
    }

    /// <summary>
    /// 扣除建造防御塔所需金币
    /// </summary>
    /// <param name="money"> 建造防御塔所需金币数 </param>
    public void Create(int money){
        Debug.Log("金币减少");
        Debug.Log(gold);
        Debug.Log(goldNum.text);
        gold=gold-money;
        goldNum.text=""+gold;
        Debug.Log(gold);
        Debug.Log(goldNum.text);
    }

    
    // Update is called once per frame
    void Update()
    {
        //goldNum.text=""+gold;
    }
}
