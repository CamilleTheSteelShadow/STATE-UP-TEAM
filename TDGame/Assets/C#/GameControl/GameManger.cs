using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    public static GameManger Instance;
    private EnemySpawner enemySpawner;

    void Awake()
    {
        Instance = this;
        enemySpawner = GetComponent<EnemySpawner>();
    }
   
    public void Win()
    {
      
    }

    public void Failed()
    {
        enemySpawner.Stop();
    }
}
