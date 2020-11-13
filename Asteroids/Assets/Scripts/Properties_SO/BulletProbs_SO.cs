using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Bullet", menuName = "SO/Bullet")]

public class BulletProbs_SO : ScriptableObject
{
    public Bullet BulletPrefab;
    public float Speed;
}
