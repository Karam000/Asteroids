using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : CommonBehaviours
{
    [SerializeField] AsteroidProbs_SO AsteroidProbs;
    private static GameObject asteroid;
    private static Rigidbody2D rb;
    private static Vector2 direction;

    private void Awake()
    {
         direction = new Vector2(Random.Range(1, 2), Random.Range(1, 2));
    }
    private void FixedUpdate()
    {
        Move();
    }
    private void Update()
    {
        EdgeCrossBehaviour();
    }
    public GameObject spawn(Vector2 position, Transform parent = null)
    {
        asteroid = Instantiate(this.gameObject, new Vector3(position.x,position.y,0),Quaternion.identity,parent);
        rb = asteroid.GetComponent<Rigidbody2D>();
        return asteroid;
    }

    public void Move()
    {
       
        if (asteroid != null)
        {
            rb.velocity = AsteroidProbs.Speed * direction;
        }
    }
}
