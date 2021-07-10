using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcherTower : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var towerface=transform.Find("towerface");
        towerface.gameObject.SetActive(false);
    }

    //显示面板
    public void TowerFaceShowClick(){
        var towerface=transform.Find("towerface");
        if(towerface.gameObject.activeInHierarchy){
            towerface.gameObject.SetActive(false);
        }else{
            towerface.gameObject.SetActive(true);
        }
    }

    //出售防御塔
    public void SellClick(){
        GameObject builder=transform.parent.gameObject;
        //GameObject face = builder.transform.Find("face").gameObject; 
        GameObject builderBtn = builder.transform.Find("builderBtn").gameObject; 
        //face.gameObject.SetActive(true);
        builderBtn.gameObject.SetActive(true);
        MonoBehaviour.Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
