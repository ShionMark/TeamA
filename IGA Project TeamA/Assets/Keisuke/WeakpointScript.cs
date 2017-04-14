using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WeakpointScript : MonoBehaviour
{
    public GameObject Explosion;    //Explosion effect
    public GameObject Armor;    //Aemor Object

    void OnCollisionEnter(Collision collision)
    {
        //Explosion only when you hit the specified object
        if (collision.gameObject.name == "Bullet")
        {
            if (Armor == null)
            {
                Instantiate(Explosion, new Vector3(transform.position.x, transform.position.y,
                                                             transform.position.z), Quaternion.identity);
                Destroy(this.gameObject);
                GameObject.Destroy(Armor);
                GameObject.Destroy(collision.gameObject);

            }
            GameObject.Destroy(collision.gameObject);
        }
    }
}
