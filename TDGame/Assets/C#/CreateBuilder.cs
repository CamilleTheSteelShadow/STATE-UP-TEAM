using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBuilder : MonoBehaviour
{

    public GameObject tower1;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(tower1,transform).transform.localPosition = new Vector2(217,1);
        Instantiate(tower1,transform).transform.localPosition = new Vector2(274,-238);
        Instantiate(tower1,transform).transform.localPosition = new Vector2(154,-123);
        Instantiate(tower1,transform).transform.localPosition = new Vector2(-25,-238);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
