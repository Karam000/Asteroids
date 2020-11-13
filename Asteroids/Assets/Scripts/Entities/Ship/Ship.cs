using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : CommonBehaviours
{
    [SerializeField] ShipProbs_SO ShipProbs;

    private void FixedUpdate()
    {
        Move();
    }
    private void Move()
    {
        MyRB.velocity = new Vector2(Input.GetAxis("Horizontal") * ShipProbs.Speed * Time.deltaTime, Input.GetAxis("Vertical") * ShipProbs.Speed * Time.deltaTime);
    }
}
