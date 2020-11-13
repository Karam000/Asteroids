using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Ship Ship;
    [SerializeField] Asteroid[] Asteroids;
    [SerializeField] Bullet Bullet;
    void Start()
    {
        //Instantiate(Ship.ShipPrefab.gameObject);
        //Instantiate(Asteroids[0].AsteroidPrefab.gameObject);
        //Instantiate(Bullet.BulletPrefab.gameObject);
        Bullet.spawn();
    }

    void Update()
    {
        
    }
}
