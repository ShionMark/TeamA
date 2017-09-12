using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StageBGM
{

    public class MainBGMSoundSystem : MonoBehaviour
    {

        public AudioClip Stage01_BGM;  //ステージ1BGM
        public AudioClip Stage02_BGM;  //ステージ2BGM
        public AudioClip Stage03_BGM;  //ステージ3BGM
        public AudioClip Stage04_BGM;  //ステージ4BGM
        public AudioClip Stage05_BGM;  //ステージ5BGM
        AudioSource StageBGM;
        public static int StageBGM_number = 1;
        public static bool BGM_Change = true;

        // Use this for initialization
        void Start()
        {
            this.StageBGM = GetComponent<AudioSource>();
            StageBGM.loop = true;
        }

        // Update is called once per frame
        void Update()
        {
            if (BGM_Change)
            {
                switch (StageBGM_number)
                {
                    case 1:
                       // this.StageBGM.PlayOneShot(this.Stage01_BGM);
                        StageBGM.clip = Stage01_BGM;
                        StageBGM.Play();
                        break;
                    case 2:
                        this.StageBGM.Stop();
                        //this.StageBGM.PlayOneShot(this.Stage02_BGM);
                        StageBGM.clip = Stage02_BGM;
                        StageBGM.Play();
                        break;
                    case 3:
                        this.StageBGM.Stop();
                        //this.StageBGM.PlayOneShot(this.Stage03_BGM);
                        StageBGM.clip = Stage03_BGM;
                        StageBGM.Play();
                        break;
                    case 4:
                        this.StageBGM.Stop();
                        //this.StageBGM.PlayOneShot(this.Stage04_BGM);
                        StageBGM.clip = Stage04_BGM;
                        StageBGM.Play();
                        break;
                    case 5:
                        this.StageBGM.Stop();
                        //this.StageBGM.PlayOneShot(this.Stage05_BGM);
                        StageBGM.clip = Stage05_BGM;
                        StageBGM.Play();
                        break;
                    default:
                        break;
                }
                BGM_Change = false;
            }
        }
    }
}