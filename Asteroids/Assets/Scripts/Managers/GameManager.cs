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
        Initialize();
    }
    private void FixedUpdate()
    {
        Asteroids[0].Move(new Vector2(0, 1));
    }
    void Update()
    {

    }

    private void Initialize()
    {
        Vector2 pos = new Vector2(Random.Range(0, 5), Random.Range(0, 5));
        Asteroids[0].spawn(pos);
    }
}
