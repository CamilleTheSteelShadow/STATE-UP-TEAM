/*****************************************************

*　　功能　　　　　　显示关卡信息面板、设置按钮

*　　作者　　　　　　伍迎

*　　时间　　　　　　2021.07.10

*　　

*　　修改说明　　　　.......

*　　。。。

*******************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public GameObject information;
    public GameObject setBtn;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(information,transform).transform.localPosition = new Vector2(0,0);
        Instantiate(setBtn,transform).transform.localPosition = new Vector2(0,0);
    }

    /*public void SettingClick(){
        Instantiate(settingFace,transform).transform.localPosition = new Vector2(0,0);
    }

    public void CloseSettingFace(){
        var setF=transform.Find("settingFace");
        MonoBehaviour.Destroy(setF);
    }*/

    // Update is called once per frame
    void Update()
    {
        
    }
}
