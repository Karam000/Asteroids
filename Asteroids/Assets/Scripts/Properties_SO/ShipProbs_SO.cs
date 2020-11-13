using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Ship",menuName ="SO/Ship")]
public class ShipProbs_SO : ScriptableObject
{
    public GameObject Shiprefab;
    public int NumberOfLives;
    public float Speed;
}
