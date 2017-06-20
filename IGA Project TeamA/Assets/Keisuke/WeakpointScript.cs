﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Itsuki;

namespace Itsuki
{
    public class WeakpointScript : MonoBehaviour
    {
        public GameObject Explosion;    //Explosion effect
        public GameObject Armor;    //Aemor Object

        void OnCollisionEnter(Collision collision)
        {
            //Explosion only when you hit the specified object
            if (collision.gameObject.name == "Fallingobject")
            {
                if (Armor == null)
                {
                    Instantiate(Explosion, new Vector3(transform.position.x, transform.position.y,
                                                                 transform.position.z), Quaternion.identity);
                    Itsuki.SpawnPoint.spawnFlag = true; //エネミーが出るようにする
                    Destroy(this.gameObject);
                    GameObject.Destroy(Armor);
                    GameObject.Destroy(collision.gameObject);
                    
                }
                GameObject.Destroy(collision.gameObject);
            }
        }
    }
}