using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Itsuki
{
    public class ArmorScript : MonoBehaviour
    {
<<<<<<< HEAD:IGA Project TeamA/Assets/Keisuke/ArmorScript.cs

        void OnCollisionEnter(Collision collision)
=======
        //Explosion only when you hit the specified object
        if (collision.gameObject.name == "Fallingobject")
>>>>>>> origin/master:IGA Project TeamA/Assets/Keisuke/Script/ArmorScript.cs
        {
            //Explosion only when you hit the specified object
            if (collision.gameObject.name == "Fallingobject")
            {
                Destroy(this.gameObject);
                GameObject.Destroy(collision.gameObject);
            }
        }
    }
}