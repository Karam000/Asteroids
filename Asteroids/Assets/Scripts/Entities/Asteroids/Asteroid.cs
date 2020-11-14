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
       // Move();
    }
    private void Update()
    {
        EdgeCrossBehaviour();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("collided");
        if (collision.gameObject.GetComponent<Bullet>())
        {
            Destroy(collision.gameObject);
            CollideWithBullet();
        }
    }
   

    //private void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log("collided");
    //    if(collision.gameObject.GetComponent<Bullet>())
    //    {
    //        CollideWithBullet();
    //    }
    //}
    private void CollideWithBullet()
    {
        int size = (int)this.AsteroidProbs.asteroidSize;
        if(size > 0)
        {
            for (int i = 0; i < 2; i++)
            {
                this.AsteroidProbs.NextSmallerAsteroid.spawn(this.transform.position);
                this.AsteroidProbs.NextSmallerAsteroid.Move();
            }
        }
        Destroy(this.gameObject);
    }
    public override Rigidbody2D spawn(Vector2 position, Transform parent = null)
    {
        MyRB = base.spawn(position, parent);
        return MyRB;
    }
   
    public void Move()
    {
        MyRB.velocity = AsteroidProbs.Speed * direction.normalized;
    }
}
