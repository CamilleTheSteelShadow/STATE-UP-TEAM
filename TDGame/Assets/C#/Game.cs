using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public GameObject information;
    



    // Start is called before the first frame update
    void Start()
    {
        Instantiate(information,transform).transform.localPosition = new Vector2(0,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
   
}
