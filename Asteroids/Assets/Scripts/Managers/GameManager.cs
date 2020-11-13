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
   
    void Update()
    {
        //LastTime = GenerateRandomAsteroid(LastTime);
    }

    private void Initialize()
    {
        Ship.spawn(new Vector2(0, 0));
    }

    private float GenerateRandomAsteroid(float lastTime)
    {
        if (Time.time - lastTime >= 3)
        {
            int randomAsteroidType = Random.Range(0, Asteroids.Length);
            Vector2 RandomSpawnPosition = new Vector2(Random.Range(0, 5), Random.Range(0, 5));
            Asteroids[randomAsteroidType].spawn(RandomSpawnPosition);
            lastTime = Time.time;
        }
        return lastTime;
    }
   
}
