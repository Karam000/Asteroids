using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] ShipProbs_SO Ship;
    [SerializeField] AsteroidProbs_SO[] Asteroids;
    [SerializeField] BulletProbs_SO Bullet;
    void Start()
    {
        Instantiate(Ship.ShipPrefab.gameObject);
        Instantiate(Asteroids[0].AsteroidPrefab.gameObject);
        Instantiate(Bullet.BulletPrefab.gameObject);

    }

    void Update()
    {
        
    }
}
