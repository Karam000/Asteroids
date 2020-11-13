using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    [SerializeField] AsteroidProbs_SO AsteroidProbs;
    private GameObject asteroid;
    private Rigidbody2D rb;

    private void Awake()
    {
      
    }
    public void spawn(Vector2 position, Transform parent = null)
    {
        asteroid = Instantiate(this.gameObject, new Vector3(position.x,position.y,0),Quaternion.identity,parent);
        rb = asteroid.GetComponent<Rigidbody2D>();
    }

    public void Move(Vector2 direction)
    {
        rb.velocity = AsteroidProbs.Speed * direction;
    }
}
