using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PM
{
    public class PlayerMove : MonoBehaviour
    {

        private ParticleSystem pmp;
        public static bool PMP = false;

     //   public GameObject Gauge;
     //   public jikiMove1 jikiMove1;

        // Use this for initialization
        void Start()
        {
          //  jikiMove1 = Gauge.GetComponent<jikiMove1>();
            pmp = this.GetComponent<ParticleSystem>();
            pmp.Stop();
        }

        // Update is called once per frame
        void Update()
        {
           // jikiMove1.PlayerMove();

            if (PMP)
            {
                PMP = false;
                pmp.Play();
            }
            }
    }
}