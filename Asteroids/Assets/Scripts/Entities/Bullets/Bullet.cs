using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] BulletProbs_SO BulletProbs;

    public void spawn()
    {
        Instantiate(this.gameObject);
    }
}
