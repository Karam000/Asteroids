using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
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
        Destroy(this.gameObject, 7);
    }

    private void Move()
    {
        GameObject MyBullet = MyRB.gameObject;
        MyRB.velocity = MyBullet.transform.right * BulletProbs.Speed * Time.deltaTime;
    }
}
