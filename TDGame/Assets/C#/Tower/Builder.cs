/*****************************************************

*　　功能　　　　　　建造防御塔功能

*　　作者　　　　　　伍迎

*　　时间　　　　　　2021.07.10

*　　

*　　修改说明　　　　.......

*　　。。。

*******************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Builder : MonoBehaviour
{

    public GameObject ArcherTower;
    public GameObject MagicTower;

    public Information inf;

    int levelOneMoney;

    // Start is called before the first frame update
    void Start()
    {
        var face=transform.Find("face");
        face.gameObject.SetActive(false);
    }
    
    /// <summary>
    /// 点击事件：显示和关闭建造面板
    /// </summary>
    public void FaceShowClick(){
        var face=transform.Find("face");
        if(face.gameObject.activeInHierarchy){
            face.gameObject.SetActive(false);
        }else{
            face.gameObject.SetActive(true);
        }
    }

    /// <summary>
    /// 点击事件：建造防御塔ArcherTower
    /// </summary>
    public void CreateArcherTower(){
        if(Information.gold>=50){
            var builderBtn=transform.Find("builderBtn");
            builderBtn.gameObject.SetActive(false);
            var face=transform.Find("face");
            face.gameObject.SetActive(false);
            Instantiate(ArcherTower,transform).transform.localPosition = new Vector2(0,0);
            levelOneMoney = ArcherTower.GetComponent<ArcherTower>().levelOneMoney;
            inf.GoldDecrease(levelOneMoney);
        }
        
    }

    /// <summary>
    /// 点击事件：建造防御塔MagicTower
    /// </summary>
    public void CreateMagicTower(){
        if(Information.gold>=50){
            var builderBtn=transform.Find("builderBtn");
            builderBtn.gameObject.SetActive(false);
            var face=transform.Find("face");
            face.gameObject.SetActive(false);
            Instantiate(MagicTower,transform).transform.localPosition = new Vector2(0,0);
            levelOneMoney = MagicTower.GetComponent<MagicTower>().levelOneMoney;
            inf.GoldDecrease(levelOneMoney);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
