using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmorScript : MonoBehaviour {

    void OnCollisionEnter(Collision collision)
    {
        //Explosion only when you hit the specified object
        if (collision.gameObject.name == "Fallingobject")
        {

            GameObject.Destroy(collision.gameObject);
        }
    }
}
