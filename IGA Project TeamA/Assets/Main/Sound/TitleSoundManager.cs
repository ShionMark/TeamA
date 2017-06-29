using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TSound
{
    public class TitleSoundManager : MonoBehaviour
    {
        private AudioSource Tsound;
        public static bool SFlg;
        // Use this for initialization
        void Start()
        {
            Tsound = GetComponent<AudioSource>();
        }

        // Update is called once per frame
        void Update()
        {
            if (SFlg)
            {
                Tsound.PlayOneShot(Tsound.clip);
                SFlg = false;
            }
        }
    }
}
