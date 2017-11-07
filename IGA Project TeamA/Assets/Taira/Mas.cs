using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Taira;
namespace Taira
{
    public class Mas : MonoBehaviour
    {

        void Start()
        {
            Taira.EnemyShooting.Masupa_D = this.gameObject;
            this.gameObject.SetActive(false);
        }

        void Update()
        {

        }

        /*void OnParticleCollision(GameObject coll)
        {
            if (coll.gameObject.tag == "Player")
            {
                Asuka.HPBar.HitPattern = 1;
            }
        }*/
    }
}