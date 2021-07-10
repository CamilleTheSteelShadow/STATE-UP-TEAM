using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Information : MonoBehaviour
{
    public Text life;
    public Text gold;
  
    // Start is called before the first frame update
    void Start()
    {
        Scene scene = SceneManager.GetActiveScene ();
        
        switch(scene.name){
            case "Level1":
            life.text="10";
            gold.text="100";
            break;

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
