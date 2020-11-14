using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : CommonBehaviours
{
    [SerializeField] BulletProbs_SO BulletProbs;
    private static Rigidbody2D MyRB;
    private static GameObject MyBullet;

    public void spawn(Vector2 position, Quaternion rotation, Transform parent = null)
    {
        EventManager.Instance.ShipDie.AddListener(OnShipLoseLife);
        MyRB = Instantiate(this.gameObject,position,rotation,parent).GetComponent<Rigidbody2D>();
        MyBullet = MyRB.gameObject;
    }

    private void Update()
    {
        Move();
        EdgeCrossBehaviour();
        Destroy(this.gameObject, 7);
    }
    private void OnShipLoseLife()
    {
        Debug.Log("bullet destroy");
        Destroy(MyBullet);
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
