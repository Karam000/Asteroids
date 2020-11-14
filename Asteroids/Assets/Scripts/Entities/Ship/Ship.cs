using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : CommonBehaviours
{
    [SerializeField] ShipProbs_SO ShipProbs;
    [SerializeField] Bullet BulletPrefab;
    protected Rigidbody2D MyRB;
   

    public override Rigidbody2D spawn(Vector2 position, Transform parent = null)
    {
        MyRB = base.spawn(position, parent);
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
    public void Move()
    {
        float VerticalValue = Input.GetAxis("Vertical");
        float HorizontalValue = Input.GetAxis("Horizontal");
        GameObject MyShip = MyRB.gameObject;
        MyRB.velocity = MyShip.transform.up * VerticalValue * ShipProbs.Speed * Time.deltaTime;
        MyShip.transform.Rotate(this.transform.forward, -HorizontalValue);
    }

    public void Shoot()
    {
        BulletPrefab.spawn(this.transform.position, this.transform.rotation);
    }
}
