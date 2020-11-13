using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : CommonBehaviours
{
    [SerializeField] AsteroidProbs_SO AsteroidProbs;
    private static Vector2 direction;

    private void Awake()
    {
        do
        {
            direction = new Vector2(Random.Range(0, 5), Random.Range(0, 5));
        } while (direction == new Vector2(0, 0));
    }
    private void FixedUpdate()
    {
        Move();
    }
    private void Update()
    {
        EdgeCrossBehaviour();
    }

    private void Move()
    {
        MyRB.velocity = AsteroidProbs.Speed * direction.normalized;
    }
}
