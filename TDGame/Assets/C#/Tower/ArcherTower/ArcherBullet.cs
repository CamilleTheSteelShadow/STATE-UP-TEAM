using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcherBullet : MonoBehaviour
{

    public GameObject target;

    private Vector2 speed=new Vector2(1,1);

    /// <summary>
    /// 设置子弹目标
    /// </summary>
    /// <param name="EnemyTarget"></param>
    public void SetTarget(GameObject EnemyTarget){
        this.target=EnemyTarget;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    /// <summary>
    /// 检测攻击Enemy
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Enemy")
        {
            MonoBehaviour.Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target.transform );
        transform.Translate(transform.forward * Time.deltaTime * speed);
        //rigidbody.MovePosition(rigidbody.position + speed * Time.deltaTime);
    }
}
