using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sound
{
    public class SoundSyastem : MonoBehaviour
    {

        AudioSource audioSource;
        public  List<AudioClip> audioClip = new List<AudioClip>();
        public static int SoundOn = -1;

        // Use this for initialization
        void Start()
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Update is called once per frame
        void Update()
        {

            if (SoundOn != -1)
            {

                audioSource.PlayOneShot(audioClip[SoundOn],0.5f);
                SoundOn = -1;
            }
        }
    }
}
