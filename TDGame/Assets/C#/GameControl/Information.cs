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

    public static int life=0;
    public static int gold=0;
  
    // Start is called before the first frame update
    void Start()
    {
        Scene scene = SceneManager.GetActiveScene ();

        /// <summary>
        /// 根据关卡初始化生命值和金币数
        /// </summary>
        /// <value></value>
        switch(scene.name){
            case "Level1":
            Information.life=10;
            Information.gold=120;
            break;

        }
        Debug.Log(Information.gold);
        Debug.Log(goldNum.text);
    }

    /// <summary>
    /// 扣除金币
    /// </summary>
    /// <param name="money"> 建造防御塔所需金币数 </param>
    public void GoldDecrease(int money){
        Information.gold=Information.gold-money;
    }

    /// <summary>
    /// 获得金币
    /// </summary>
    /// <param name="money"></param>
    public void GoldAdd(int money){
        Information.gold=Information.gold+money;
    }

    
    // Update is called once per frame
    void Update()
    {
        //实时更新生命值和金币数
        lifeNum.text=""+Information.life;
        goldNum.text=""+Information.gold;
    }
}
