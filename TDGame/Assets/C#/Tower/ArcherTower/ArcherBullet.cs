using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcherBullet : MonoBehaviour
{

    public GameObject target;

    //public Transform target; //瞄准的目标

    private Vector2 speed=new Vector2(1,1);

    /// <summary>
    /// 设置子弹目标
    /// </summary>
    /// <param name="EnemyTarget"></param>
    public void SetTarget(GameObject enemyTarget){
        this.target=enemyTarget;
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
        //transform.GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + speed * Time.deltaTime);
    }
}
