/*****************************************************

*　　功能　　　　　　设置面板功能

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

public class SettingButton : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        var settingFace=transform.Find("settingFace");
        settingFace.gameObject.SetActive(false);
    }

    /// <summary>
    /// 点击事件：打开面板
    /// </summary>
    public void SettingClick(){
        var settingFace=transform.Find("settingFace");
        settingFace.gameObject.SetActive(true);
    }

    /// <summary>
    /// 点击事件：关闭面板
    /// </summary>
    public void CloseSettingFace(){
        var settingFace=transform.Find("settingFace");
        settingFace.gameObject.SetActive(false);
    }

    /// <summary>
    /// 点击事件：返回选关界面
    /// </summary>
    public void ReturnSelectLevel(){
        SceneManager.LoadScene("SelectLevel");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
