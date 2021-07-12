/*****************************************************

*　　功能　　　　　　防御塔ArcherTower的升级、出售功能

*　　作者　　　　　　伍迎

*　　时间　　　　　　2021.07.10

*　　

*　　修改说明　　　　.......

*　　。。。

*******************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcherTower : MonoBehaviour
{
    /// <summary>建造防御塔ArcherTower所需金币</summary>
    public int money=50;
    
    //创建一个集合，当Enemy移动到塔范围之内把其添加到集合里，否则将其移除集合
    public List<GameObject> listEnemy = new List<GameObject>();

    public GameObject ArcherBullet;

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
        //GameObject face = builder.transform.Find("face").gameObject; 
        GameObject builderBtn = builder.transform.Find("builderBtn").gameObject; 
        //face.gameObject.SetActive(true);
        builderBtn.gameObject.SetActive(true);
        MonoBehaviour.Destroy(this.gameObject);
    }

    /// <summary>
    /// 检测敌人进塔
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Enemy")
        {
            listEnemy.Add(other.gameObject);
        }
    }

    /// <summary>
    /// 检测Enemy出塔
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            listEnemy.Remove(other.gameObject);
        }
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
