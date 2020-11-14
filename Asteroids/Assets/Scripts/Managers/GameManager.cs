using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Ship Ship;
    [SerializeField] Asteroid[] Asteroids;
    [SerializeField] Bullet Bullet;
    
    private float LastTime;
    void Start()
    {
        LastTime = Time.time;
        Initialize();
    }

    private void FixedUpdate()
    {
        Ship.Move();
    }
    void Update()
    {
        //GenerateRandomAsteroid();
    }

    private void Initialize()
    {
        Ship.spawn(new Vector2(0, 0));
    }

    private void GenerateRandomAsteroid()
    {
        if (Time.time - LastTime >= 1.5f)
        {
            int randomAsteroidType = Random.Range(0, Asteroids.Length);
            Vector2 RandomSpawnPosition = new Vector2(Random.Range(0, 5), Random.Range(0, 5));
            Asteroids[randomAsteroidType].spawn(RandomSpawnPosition);
            LastTime = Time.time;
        }
    }
   
}
