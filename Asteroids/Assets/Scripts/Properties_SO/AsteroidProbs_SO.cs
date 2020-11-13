using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Asteroid", menuName = "SO/Asteroid")]
public class AsteroidProbs_SO : ScriptableObject
{
    [HideInInspector]
    public enum AsteroidSize
    {
        Big,
        Medium,
        Small
    }
    public Asteroid AsteroidPrefab;
    public AsteroidSize asteroidSize;
    public float Speed;
    public int DestructionScore;
}
