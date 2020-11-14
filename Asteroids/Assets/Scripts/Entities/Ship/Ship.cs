using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : CommonBehaviours
{
    [SerializeField] ShipProbs_SO ShipProbs;
    [SerializeField] Bullet BulletPrefab;
    private Rigidbody2D MyRB;
    private GameObject MyShip;

    public override Rigidbody2D spawn(Vector2 position, Transform parent = null)
    {
        MyRB = base.spawn(position, parent);
        MyShip = MyRB.gameObject;
        return MyRB;
    }
    private void Update()
    {
        EdgeCrossBehaviour();

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    protected new void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Asteroid>())
        {
            Debug.Log("DIE SHIP");
        }
        else
            base.OnTriggerEnter2D(collision);
    }
    public void Move()
    {
        if(MyRB != null)
        {
            float VerticalValue = Input.GetAxis("Vertical");
            float HorizontalValue = Input.GetAxis("Horizontal");
            MyRB.velocity = MyShip.transform.up * VerticalValue * ShipProbs.Speed * Time.deltaTime + MyShip.transform.right * HorizontalValue * (ShipProbs.Speed / ShipProbs.SteeringRotation) * Time.deltaTime;
            MyShip.transform.Rotate(this.transform.forward, -HorizontalValue * ShipProbs.SteeringRotation);
        }
    }
    public void Shoot()
    {
        BulletPrefab.spawn(this.transform.position + this.transform.up * 1.1f, this.transform.rotation);
    }
    protected override void CollideWithBullet()
    {
        Debug.Log("DIE FUNCTIONALITY");
        Destroy(this.gameObject);
    }
}
