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
    public int levelOneMoney=50;

    /// <summary> 出售一级防御塔所得金币 </summary>
    public int sellLevelOneMoney=25;
    
    //创建一个集合，当Enemy移动到塔范围之内把其添加到集合里，否则将其移除集合
    public List<GameObject> listEnemy = new List<GameObject>();

    public GameObject ArcherBullet;
    public Information inf;

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
    private void OnTriggerEnter(Collider coll)
    {
        Debug.Log("有东西");
        if (coll.gameObject.tag == "Enemy")
        {
            Debug.Log("敌人在塔里");
            listEnemy.Add(coll.gameObject);
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

    private void OnTriggerStay(Collider other)
    {
        float timer=0;
        if (other.gameObject.tag == "Enemy")
        {
            if ( timer > 1  &&  listEnemy.Count > 0)
        {
            Attack();
            timer = 0;
        }
        else
        {
            timer += Time.deltaTime;
        }
        }
    }

    /// <summary>
    /// 生成子弹攻击
    /// </summary>
    public void Attack(){
        Instantiate(ArcherBullet,transform).transform.localPosition = new Vector2(0,0);
        ArcherBullet.GetComponent<ArcherBullet>().SetTarget(listEnemy[0]);
    }

    

    // Update is called once per frame
    void Update()
    {
        if( listEnemy.Count > 0){
            Debug.Log("有敌人");
        }
      

    }
}
