using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Enemy : MonoBehaviour
{
    [SerializeField]
    private GameObject[] Enemys;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        //Move();
    }

    public void CreateEnemy()
    {
        string type = RandomEnemy();
        for (int i = 0; i < Enemys.Length; i++)
        {
            if (Enemys[i].name == type)
            {
                Instantiate(Enemys[i], transform).transform.localPosition = new Vector2(-141, -162);
            }
        }
    }

    public string RandomEnemy()
    {
        int Index = Random.Range(0, 2);
        string type = string.Empty;
        switch (Index)
        {
            case 0:
                type = "enemy1walk";
                break;
            case 1:
                type = "enemy2walk";
                break;
            case 2:
                type = "enemy3walk";
                break;
        }
        return type;
    }

    /*public void Move()
    {
        transform.Translate();
    }*/
}
