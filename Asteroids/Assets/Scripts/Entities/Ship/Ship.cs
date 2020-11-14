using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : CommonBehaviours
{
    [SerializeField] ShipProbs_SO ShipProbs;
    protected Rigidbody2D MyRB;

    //private void FixedUpdate()
    //{
    //    Move();
    //}

    public override Rigidbody2D spawn(Vector2 position, Transform parent = null)
    {
        MyRB = base.spawn(position, parent);
        return MyRB;
    }
    //public void spawn(Vector2 position, Transform parent = null)
    //{
    //    GameObject SpawnedObject = Instantiate(this.gameObject, new Vector3(position.x, position.y, 0), Quaternion.identity, parent);
    //    MyRB = SpawnedObject.GetComponent<Rigidbody2D>();
    //}
    private void Update()
    {
        EdgeCrossBehaviour();
    }
    public void Move()
    {
        float VerticalValue = Input.GetAxis("Vertical");
        float HorizontalValue = Input.GetAxis("Horizontal");
        GameObject MyShip = MyRB.gameObject;
        MyRB.velocity = MyShip.transform.up * VerticalValue * ShipProbs.Speed * Time.deltaTime;
        MyShip.transform.Rotate(this.transform.forward, -HorizontalValue);
    }
}
