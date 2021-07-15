using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Enemy : MonoBehaviour
{ 
    public float speed = 1;
    public int hp = 150;
    public GameObject enemyDieEffect;//������������
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


     void Move()//�õ�·���㣬��������·����һ��һ���ƶ�
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

    void ReachDestination()//���˵����յ㣬����
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

    void OnDestroy()//���˱�����ܣ�����
    {
        EnemySpawner.CountEnemyAlive--;
        
    }

    public void TakeDamage(int damage)//�����ܵ��˺�
    {
        if (hp <= 0) return;//�����ܵ��˺�֮ǰ���������ֵ�ѿգ��򷵻�
        hp -= damage;
        hpSlider.value = (float)hp / totalHp;
        if (hp <= 0)//�����ܵ��˺�������ֵ�ѿգ�������
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
