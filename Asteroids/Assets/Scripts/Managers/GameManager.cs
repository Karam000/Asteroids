using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Ship Ship;
    [SerializeField] Asteroid[] Asteroids;

    [SerializeField] Transform AsteroidParent;
    
    private float LastTime;
    void Awake()
    {
        InitializeGame();
    }
    private void FixedUpdate()
    {
        Ship.Move();
    }
    void Update()
    {
        GenerateRandomAsteroid();
    }

    private void InitializeGame()
    {
        LastTime = Time.time;
        Ship.spawn(new Vector2(0, 0));
    }

    private void GenerateRandomAsteroid()
    {
        if (Time.time - LastTime >= 3f && AsteroidParent.childCount < 7)
        {
            int randomAsteroidType = Random.Range(0, Asteroids.Length);
            Vector2 RandomSpawnPosition = new Vector2(Random.Range(5, 10), Random.Range(5, 10));
            Asteroids[randomAsteroidType].spawn(RandomSpawnPosition,AsteroidParent);
            LastTime = Time.time;
        }
    }
   
}
