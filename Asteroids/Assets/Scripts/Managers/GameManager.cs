using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Ship Ship;
    [SerializeField] Asteroid[] Asteroids;
    [SerializeField] Bullet Bullet;

    float LastTime;

    //private List<Asteroid> InstantiatedAsteroids = new List<Asteroid>(); 
    void Start()
    {
        //Instantiate(Ship.ShipPrefab.gameObject);
        //Instantiate(Asteroids[0].AsteroidPrefab.gameObject);
        //Instantiate(Bullet.BulletPrefab.gameObject);
        //Initialize();
        LastTime = Time.time;
    }
   
    void Update()
    {
        LastTime = GenerateRandomAsteroid(LastTime);
    }

    private void Initialize()
    {
        //foreach (var Asteroid in Asteroids)
        //{
        //    Vector2 pos = new Vector2(Random.Range(0, 5), Random.Range(0, 5));
        //    InstantiatedAsteroids.Add(Asteroid.spawn(pos).GetComponent<Asteroid>());
        //}
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
