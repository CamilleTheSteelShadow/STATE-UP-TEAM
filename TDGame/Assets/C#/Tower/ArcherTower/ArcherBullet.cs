/*****************************************************

*　　功能　　　　　　子弹ArcherBullet

*　　作者　　　　　　伍迎

*　　时间　　　　　　2021.07.14

*　　

*　　修改说明　　　　.......

*　　。。。

*******************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcherBullet : MonoBehaviour
{
    /// <summary> 目标敌人坐标 </summary>
    public Vector2 enemyPosition;

    public int harm=1;

    //public float speed=1000;

    /// <summary>
    /// 设置子弹目标
    /// </summary>
    /// <param name="EnemyTarget"></param>
    public void SetTarget(Vector2 enemyPosition){
        this.enemyPosition=enemyPosition;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void MoveToEnemy(){
        float step = 5 * Time.deltaTime;
        this.transform.position=Vector2.MoveTowards(this.transform.position, this.enemyPosition, step);  
    }

    

    /// <summary>
    /// 检测攻击Enemy
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.tag == "Enemy")
        {
            MonoBehaviour.Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        MoveToEnemy();
        //transform.LookAt(target.transform );
        //transform.Translate(transform.forward * Time.deltaTime * speed);
        //transform.GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + speed * Time.deltaTime);
    }
}
