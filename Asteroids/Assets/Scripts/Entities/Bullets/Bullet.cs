using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : CommonBehaviours
{
    [SerializeField] BulletProbs_SO BulletProbs;
    static Rigidbody2D MyRB;

    public void spawn(Vector2 position, Quaternion rotation, Transform parent = null)
    {
        MyRB = Instantiate(this.gameObject,position,rotation,parent).GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Move();
        EdgeCrossBehaviour();
        Destroy(this.gameObject, 7);
    }

    private void Move()
    {
        if(MyRB != null)
        {
            GameObject MyBullet = MyRB.gameObject;
            MyRB.velocity = MyBullet.transform.up * BulletProbs.Speed * Time.deltaTime;
        }
    }
}
