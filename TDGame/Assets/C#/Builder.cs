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

    public Information inf;

    int money;

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
        Debug.Log("建造防御塔1");
        var builderBtn=transform.Find("builderBtn");
        builderBtn.gameObject.SetActive(false);
        var face=transform.Find("face");
        face.gameObject.SetActive(false);
        Instantiate(ArcherTower,transform).transform.localPosition = new Vector2(0,0);
        
        money = ArcherTower.GetComponent<ArcherTower>().money;
        inf.Create(money);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
