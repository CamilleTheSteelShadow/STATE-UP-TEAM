using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public static int CountEnemyAlive = 0;
    public Wave[] waves;
    public List<GameObject> listEnemy = new List<GameObject>();
    public Transform START;
    public float waveRate = 3;
    private Coroutine coroutine;

    void Start()
    {
        coroutine = StartCoroutine(SpawnEnemy());
    }

    public void Stop()
    {
        StopCoroutine(coroutine);
    }

    public void Remove(GameObject gameObject)
    {
        listEnemy.Remove(gameObject);
    }

    IEnumerator SpawnEnemy()
    {
        foreach(Wave wave in waves)
        {
            for(int i = 0; i < wave.count; i++) {
                GameObject.Instantiate(wave.enemyPrefab, START.position, Quaternion.identity);
                listEnemy.Add(this.gameObject);
                CountEnemyAlive++;
                if(i!=wave.count-1)
                yield return new WaitForSeconds(wave.rate);
            }
            while (CountEnemyAlive > 0)
            {
                yield return 0;
            }

            yield return new WaitForSeconds(waveRate);
        }
    }

    private void UpdateEnemy()
    {
        for (int i = 0; i < listEnemy.Count; i++)
        {
            if (listEnemy[i] == null)
            {
                listEnemy[i] = listEnemy[i + 1];
            }
        }
    }

    void Update()
    {
        UpdateEnemy();
    }
}
