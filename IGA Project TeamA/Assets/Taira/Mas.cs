using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Taira;

namespace Taira
{
    public class Mas : MonoBehaviour
    {

        void Update()
        {

        }

        void OnTriggerEnter(Collider coll)
        {
            if (coll.gameObject.CompareTag("Player") && Taira.EnemyShooting.pattern >= 2)
            {

            }
        }
    }
}