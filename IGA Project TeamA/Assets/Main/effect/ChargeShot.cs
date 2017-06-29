using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PM
{

    public class ChargeShot : MonoBehaviour
    {

        public static ParticleSystem cs;
        public static bool CS = false;


        // Use this for initialization
        void Start()
        {
            cs = this.GetComponent<ParticleSystem>();
            cs.Stop();
        }

        // Update is called once per frame
        void Update()
        {
            if (CS)
            {
                CS = false;
                cs.Play();
            }
        }
    }
}
