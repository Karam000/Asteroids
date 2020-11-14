using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : CommonBehaviours
{
    [SerializeField] AsteroidProbs_SO AsteroidProbs;
    private static Vector2 direction;
    protected static Rigidbody2D MyRB;

    
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

    public void Move()
    {
        MyRB.velocity = AsteroidProbs.Speed * direction.normalized;
    }
}
