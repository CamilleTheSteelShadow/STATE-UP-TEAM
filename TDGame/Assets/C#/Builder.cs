using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Builder : MonoBehaviour
{

    public GameObject tower1;

    // Start is called before the first frame update
    void Start()
    {
        var face=transform.Find("face");
        face.gameObject.SetActive(false);
    }

    public void FaceShowClick(){
        Debug.Log("dianji");

        var face=transform.Find("face");
        if(face.gameObject.activeInHierarchy){
            face.gameObject.SetActive(false);
        }else{
            face.gameObject.SetActive(true);
        }
    }

    public void CreateTower1(){
        Debug.Log("建造防御塔1");
        var builderBtn=transform.Find("builderBtn");
        builderBtn.gameObject.SetActive(false);
        var face=transform.Find("face");
        face.gameObject.SetActive(false);
        Instantiate(tower1,transform).transform.localPosition = new Vector2(0,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
