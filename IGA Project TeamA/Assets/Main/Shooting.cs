using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PM;
using Sound;

namespace Shooting
{

    public class Shooting : MonoBehaviour
    {

        // bullet prefab
        public GameObject bullet;
        // 弾丸発射点
        public Transform muzzlemain;
        public Transform muzzlesub;

        public Transform enemyposi;
        // 弾丸の速度
        public float speed = 100;

        int count;

        private bool ShootFlag;

        private AudioSource ChargeSound;


        void Start()
        {
           ChargeSound = GetComponent<AudioSource>();
            count = 0;
        }

        void Update()
        {
            //弾のエネルギー充填
            if (Input.GetMouseButtonDown(0))
            {
                ChargeSound.PlayOneShot(ChargeSound.clip);
                PM.ChargeShot.CS = true;
            }
           /* if (Input.GetMouseButton(0))
            {
                //if (count != 180) count++;
            }*/

            //弾発射
            if (Input.GetMouseButtonUp(0))
            {
                if (/*count == 180*/!PM.ChargeShot.cs.isPlaying)        //弾充填が終わっていれば発射可能
                {
                    Sound.SoundSyastem.SoundOn = 3;     //効果音の番号
                    Vector3 subGotoPosition = enemyposi.transform.position - muzzlesub.transform.position;
                    Vector3 mainGotoPosition = enemyposi.transform.position - muzzlemain.transform.position;

                    // 弾丸の複製
                    GameObject bulletsmain = GameObject.Instantiate(bullet) as GameObject;
                    GameObject bulletssub = GameObject.Instantiate(bullet) as GameObject;


                    // Rigidbodyに力を加えて発射
                    bulletsmain.GetComponent<Rigidbody>().AddForce(mainGotoPosition * speed);
                    bulletssub.GetComponent<Rigidbody>().AddForce(subGotoPosition * speed);

                    // 弾丸の位置を調整
                    bulletsmain.transform.position = muzzlemain.position;
                    bulletssub.transform.position = muzzlesub.position;

                   // count = 0;
                }
                else
                {
                    ChargeSound.Stop();
                    PM.ChargeShot.cs.Stop();
                   // count = 0;
                }
            }
            if (Input.GetMouseButtonUp(1)) {
                Vector3 subGotoPosition = enemyposi.transform.position - muzzlesub.transform.position;
                Vector3 mainGotoPosition = enemyposi.transform.position - muzzlemain.transform.position;

                // 弾丸の複製
                GameObject bulletsmain = GameObject.Instantiate(bullet) as GameObject;
                GameObject bulletssub = GameObject.Instantiate(bullet) as GameObject;


                // Rigidbodyに力を加えて発射
                bulletsmain.GetComponent<Rigidbody>().AddForce(mainGotoPosition * speed);
                bulletssub.GetComponent<Rigidbody>().AddForce(subGotoPosition * speed);

                // 弾丸の位置を調整
                bulletsmain.transform.position = muzzlemain.position;
                bulletssub.transform.position = muzzlesub.position;
            }
        }
    }
}