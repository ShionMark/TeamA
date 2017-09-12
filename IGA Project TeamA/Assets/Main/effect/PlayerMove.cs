using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PM
{
    public class PlayerMove : MonoBehaviour
    {

        private ParticleSystem pmp;
       
        public static bool PMP = false;

       

        // Use this for initialization
        void Start()
        {
           
            pmp = this.GetComponent<ParticleSystem>();
            pmp.Stop();
        }

        // Update is called once per frame
        void Update()
        {
           

            if (PMP)
            {
                
                PMP = false;
                pmp.Play();
            }
            }
    }
}