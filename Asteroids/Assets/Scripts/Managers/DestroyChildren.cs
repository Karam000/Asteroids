using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyChildren : MonoBehaviour
{
    public void DestroyMyChildren()
    {
        Debug.Log("Called");
        for (int i = 0; i < this.transform.childCount; i++)
        {
            Destroy(this.transform.GetChild(i).gameObject);
        }
    }
}
