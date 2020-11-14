using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CommonBehaviours : MonoBehaviour
{
    public virtual Rigidbody2D spawn(Vector2 position, Transform parent = null)
    {
        GameObject SpawnedObject = Instantiate(this.gameObject, new Vector3(position.x, position.y, 0), Quaternion.identity, parent);
        return SpawnedObject.GetComponent<Rigidbody2D>();
    }
    protected virtual void CollideWithBullet() { }
    protected void EdgeCrossBehaviour()
    {
        if (this.transform.position.x > 5.2f)
        {
            this.transform.position = new Vector3(-5.2f, this.transform.position.y, 0);
        }
        else if (this.transform.position.x < -5.2f)
        {
            this.transform.position = new Vector3(5.2f, this.transform.position.y, 0);
        }
        else if (this.transform.position.y > 5.2f)
        {
            this.transform.position = new Vector3(this.transform.position.x, -5.2f, 0);
        }
        else if (this.transform.position.y < -5.2f)
        {
            this.transform.position = new Vector3(this.transform.position.x, 5.2f, 0);
        }
    }
    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        if (!(this is Bullet) && collision.gameObject.GetComponent<Bullet>())
        {
            Destroy(collision.gameObject);
            CollideWithBullet();
        }
    }
    
}
