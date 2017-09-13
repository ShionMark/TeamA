using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PM
{
    public class PlayerMove : MonoBehaviour
    {

        private ParticleSystem pmp;
        public GameObject Gauge;
        public jikiMove1 jikiMove1;
        
        public static bool PMP = false;

        // Use this for initialization
        void Start()
        {
            jikiMove1 = Gauge.GetComponent<jikiMove1>();
            pmp = this.GetComponent<ParticleSystem>();
            pmp.Stop();
        }

        // Update is called once per frame
        public void Update()
        {
            if (PMP)
            {
                jikiMove1.PlayerMove();
                PMP = false;
                pmp.Play();
            }
            }
    }
}