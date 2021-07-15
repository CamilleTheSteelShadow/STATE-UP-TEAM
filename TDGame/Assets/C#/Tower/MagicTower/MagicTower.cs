/*****************************************************

*　　功能　　　　　　防御塔MagicTower的升级、出售功能

*　　作者　　　　　　伍迎

*　　时间　　　　　　2021.07.10

*　　

*　　修改说明　　　　.......

*　　。。。

*******************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicTower : MonoBehaviour
{

    /// <summary>建造防御塔MagicTower所需金币</summary>
    public int levelOneMoney=60;

    /// <summary> 出售一级防御塔所得金币 </summary>
    public int sellLevelOneMoney=30;

    public Information inf;
    public GameObject MagicBullet;


    // Start is called before the first frame update
    void Start()
    {
        var towerface=transform.Find("towerface");
        towerface.gameObject.SetActive(false);
    }

    /// <summary>
    /// 点击事件：显示防御塔面板
    /// </summary>
    public void TowerFaceShowClick(){
        var towerface=transform.Find("towerface");
        if(towerface.gameObject.activeInHierarchy){
            towerface.gameObject.SetActive(false);
        }else{
            towerface.gameObject.SetActive(true);
        }
    }

    /// <summary>
    /// 点击事件：出售防御塔
    /// </summary>
    public void SellClick(){
        GameObject builder=transform.parent.gameObject;
        GameObject builderBtn = builder.transform.Find("builderBtn").gameObject; 
        builderBtn.gameObject.SetActive(true);
        inf.GoldAdd(sellLevelOneMoney);
        MonoBehaviour.Destroy(this.gameObject);
    }


    /// <summary>
    /// 检测敌人进塔
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Instantiate(MagicBullet,transform).transform.localPosition = new Vector2(0,0);
        }
       
    }

    /// <summary>
    /// 检测Enemy出塔
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            var magicBullet=transform.Find("MagicBullet");
            MonoBehaviour.Destroy(magicBullet);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
