using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CommonBehaviours : MonoBehaviour
{
    protected static Rigidbody2D MyRB;
    public GameObject spawn(Vector2 position, Transform parent = null)
    {
        GameObject SpawnedObject = Instantiate(this.gameObject, new Vector3(position.x, position.y, 0), Quaternion.identity, parent);
        MyRB = SpawnedObject.GetComponent<Rigidbody2D>();
        return SpawnedObject;
    }
    protected void EdgeCrossBehaviour()
    {
        if (this.transform.position.x > 4.8f)
        {
            this.transform.position = new Vector3(-4.8f, this.transform.position.y, 0);
        }
        if (this.transform.position.x < -4.8f)
        {
            this.transform.position = new Vector3(4.8f, this.transform.position.y, 0);
        }
        if (this.transform.position.y > 4.8f)
        {
            this.transform.position = new Vector3(this.transform.position.y, -4.8f, 0);
        }
        if (this.transform.position.y < -4.8f)
        {
            this.transform.position = new Vector3(this.transform.position.y, 4.8f, 0);
        }
    }
}
