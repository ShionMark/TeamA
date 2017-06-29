using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PM
{
    public class weakness01 : MonoBehaviour
    {

        private ParticleSystem wnp01;
        public static bool WNP01 = false;


        // Use this for initialization
        void Start()
        {
            wnp01 = this.GetComponent<ParticleSystem>();
            wnp01.Stop();
        }

        // Update is called once per frame
        void Update()
        {
            if (WNP01)
            {
                WNP01 = false;
                wnp01.Play();
            }
        }
    }
}