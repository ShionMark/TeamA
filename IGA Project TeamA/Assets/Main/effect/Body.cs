using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace PM
{
    public class Body : MonoBehaviour
    {

        private ParticleSystem eb;
        public static bool EB = false;
        public bool EBB = false;


        // Use this for initialization
        void Start()
        {
            eb = this.GetComponent<ParticleSystem>();
            eb.Stop();
        }

        // Update is called once per frame
        void Update()
        {
            if (EB)
            {
                EB = false;
                eb.Play();
                EBB = true;
            }
            if (EBB)
            {
                if (!eb.isPlaying)
                {

                //    Gage1.HPcontroller._hp += 20;
                  //  Gage2.GageController._hp += 20; 
                    StageMove.BoxScript.ugoku = false;      //ステージを逆にスライドさせる。
                    PM.PlayerMove.PMP = true;
                    
                    EBB = false;
                }
            }
        }
    }
}
