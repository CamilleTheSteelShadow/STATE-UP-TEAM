using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;

public class StartButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var showFace=transform.Find("showFace");
        showFace.gameObject.SetActive(false);
    }

    public void StartClick(){
        SceneManager.LoadScene("SelectLevel");
    }


    public void ShowClick(){
        var showFace=transform.Find("showFace");
        showFace.gameObject.SetActive(true);
    }


    public void CloseFaceClick(){
        var showFace=transform.Find("showFace");
        showFace.gameObject.SetActive(false);
    }


    public void ExitClick(){
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        Application.Quit();
        #endif
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
