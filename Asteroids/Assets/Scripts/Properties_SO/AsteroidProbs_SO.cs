using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Asteroid", menuName = "SO/Asteroid")]
public class AsteroidProbs_SO : ScriptableObject
{
    [HideInInspector]
    public enum AsteroidSize
    {
        Big = 2,
        Medium = 1,
        Small = 0
    }
    public AsteroidSize asteroidSize;
    public float Speed;
    public int DestructionScore;
    public Asteroid NextSmallerAsteroid;
}
