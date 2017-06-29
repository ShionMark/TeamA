using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PM
{
    public class weakness02 : MonoBehaviour
    {

        private ParticleSystem wnp02;
        public static bool WNP02 = false;


        // Use this for initialization
        void Start()
        {
            wnp02 = this.GetComponent<ParticleSystem>();
            wnp02.Stop();
        }

        // Update is called once per frame
        void Update()
        {
            if (WNP02)
            {
                WNP02 = false;
                wnp02.Play();
            }
        }
    }
}