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

    public static int timer=0;

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
            listEnemy.Add(other.gameObject);
            if(listEnemy.Count>0){
                Attack();
            }
            
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
            listEnemy.Remove(other.gameObject);
        }
    }

    
    /// <summary>
    /// 生成子弹攻击
    /// </summary>
    public void Attack(){
        if ( ArcherTower.timer == 1)
            {
                Vector2 position=listEnemy[0].transform.position;
                Vector2 enemyPosition=listEnemy[0].transform.position;
                Instantiate(ArcherBullet,transform).transform.localPosition = new Vector2(0,0);
                //ArcherBullet.GetComponent<ArcherBullet>().MoveToEnemy(listEnemy[0].transform.position);
                ArcherBullet.GetComponent<ArcherBullet>().SetTarget(enemyPosition);
                ArcherTower.timer = 0;
            }else
            {
                Debug.Log("sad");
                ArcherTower.timer++;
            }
    }


    private void UpdateEnemy()
    {
        for(int i=0;i<listEnemy.Count; i++)
        {
            if(listEnemy[i] == null)
            {
                if(i==listEnemy.Count-1){
                    listEnemy[i]=listEnemy[i+1];
                }
            }
        }
    }

    

    // Update is called once per frame
    void Update()
    {
      UpdateEnemy();
    }
}
