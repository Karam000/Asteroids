using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Ship",menuName ="SO/Ship")]
public class ShipProbs_SO : ScriptableObject
{
    public Ship ShipPrefab;
    public int NumberOfLives;
    public float Speed;
}
