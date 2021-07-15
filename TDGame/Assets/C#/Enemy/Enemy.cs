using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Enemy : MonoBehaviour
{ 
    public float speed = 1;
    public int hp = 150;
    public GameObject enemyDieEffect;//敌人死亡动作
    private int totalHp;
    private Slider hpSlider;
    private int index = 0;

    private Transform[] positions;
    // Start is called before the first frame update
    void Start()
    {
        positions = Waypoints.positions;
        totalHp = hp;
        
    }
    // Update is called once per frame
    void Update()
    {
        Move();
    }


     void Move()//得到路径点，敌人沿着路径点一个一个移动
    {
        if (index > positions.Length - 1) return;
        transform.Translate((positions[index].position-transform.position).normalized * Time.deltaTime * speed);
        if (Vector3.Distance(positions[index].position, transform.position) < 0.2f)
        {
            index++;
        }
        if (index > positions.Length - 1)
        {
            ReachDestination();
        }
    }

    void ReachDestination()//敌人到达终点，销毁
    {
        if (Information.life > 0)
        {
            Information.life = Information.life - 1;
        }
        
        GameObject.Destroy(this.gameObject);
        if (Information.life == 0)
        {
            GameManger.Instance.Failed();
        }
        
    }

    void OnDestroy()//敌人被塔打败，销毁
    {
        EnemySpawner.CountEnemyAlive--;
        
    }

    public void TakeDamage(int damage)//敌人受到伤害
    {
        if (hp <= 0) return;//敌人受到伤害之前，如果生命值已空，则返回
        hp -= damage;
        hpSlider.value = (float)hp / totalHp;
        if (hp <= 0)//敌人受到伤害后，生命值已空，则死亡
        {
            Die();
        }
    }

    void Die()
    {
        GameObject effect = GameObject.Instantiate(enemyDieEffect, transform.position, transform.rotation);
        Destroy(effect, 1.5f);
        
        Destroy(this.gameObject);
       
    }
}
