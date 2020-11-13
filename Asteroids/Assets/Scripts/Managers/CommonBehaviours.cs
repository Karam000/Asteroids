using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CommonBehaviours : MonoBehaviour
{
   protected void EdgeCrossBehaviour()
    {
        if(this.transform.position .x > 4.8f)
        {
            this.transform.position = new Vector3(-4.8f, this.transform.position.y, 0);
        }
        if (this.transform.position.x < -4.8f)
        {
            this.transform.position = new Vector3(4.8f, this.transform.position.y, 0);
        }
        if (this.transform.position.y > 4.8f)
        {
            this.transform.position = new Vector3(this.transform.position.y, -4.8f , 0);
        }
        if (this.transform.position.y < -4.8f)
        {
            this.transform.position = new Vector3(this.transform.position.y, 4.8f, 0);
        }
    }
}
