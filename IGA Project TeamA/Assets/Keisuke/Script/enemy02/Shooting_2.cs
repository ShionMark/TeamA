using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PM;
using Sound;

namespace Shooting
{
    public class Shooting_2 : MonoBehaviour
    {
        const float B_SPEED = 100;//弾丸の速度
        const int COUNTMAX = 10;//撃つ間隔（オートショットモード）

        public const int AUTO_BULLET = 1;
        public const int CHARGE_BULLET = 7;

        public enum BULLET_TYPE {AUTO_SHOOT,CHARGE_SHOOT }
        //public BULLET_TYPE bullet_type;

        public GameObject bullet_auto, bullet_charge;
        public GameObject bulletsmain, bulletssub;
        // 弾丸発射点
        public Transform muzzlemain,muzzlesub;
        //撃つ方向
        public Transform enemyposi;
        // 弾丸の速度
        
        private int icount;//弾丸の間隔のカウント
        private bool isDoubleTapStart,isDoubleTap;//ダブルクリックのフラグ
        private float fdoubleTapTime; //タップ開始からの累積時間

        private AudioSource ChargeSound;

        void Start()
        {
            ChargeSound = GetComponent<AudioSource>();
            icount = 0;
        }

        void Update()
        {
            if (icount != COUNTMAX && PM.ChargeShot.CS == false) icount++;
            //------------------------------------------------------------------------------------------------

            //弾のエネルギー充填
            if (Input.GetMouseButtonUp(0) && isDoubleTap)
            {
                if (!PM.ChargeShot.cs.isPlaying)        //弾充填が終わっていれば発射可能
                {
                    Shoot(BULLET_TYPE.CHARGE_SHOOT);
                    Sound.SoundSyastem.SoundOn = 3;     //効果音の番号
                    icount = -30;
                    isDoubleTap = false;
                }
                else
                {
                    ChargeSound.Stop();
                    PM.ChargeShot.cs.Stop();
                    isDoubleTap = false;
                }
            }
            //------------------------------------------------------------------------------------------------

            if (!isDoubleTap && icount == COUNTMAX)//オートショット
            {
                Shoot(BULLET_TYPE.AUTO_SHOOT);
                icount = 0;
            }

            if (isDoubleTapStart)
            {
                fdoubleTapTime += Time.deltaTime;
                if (fdoubleTapTime < 0.2f)
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        isDoubleTapStart = false;
                        isDoubleTap = true;
                        fdoubleTapTime = 0.0f;
                        ChargeEfe();
                    }
                }
                else
                {
                    isDoubleTapStart = false;
                    fdoubleTapTime = 0.0f;
                }
            }
            else
            {
                if (Input.GetMouseButtonDown(0)) isDoubleTapStart = true;
            }

        }

        void Shoot(BULLET_TYPE bullet_type)
        {
            Vector3 subGotoPosition = enemyposi.transform.position - muzzlesub.transform.position;
            Vector3 mainGotoPosition = enemyposi.transform.position - muzzlemain.transform.position;

            // 弾丸の複製
            switch (bullet_type)
            {
                case BULLET_TYPE.AUTO_SHOOT:
                    bulletsmain = GameObject.Instantiate(bullet_auto) as GameObject;
                    bulletssub = GameObject.Instantiate(bullet_auto) as GameObject;
                    break;
                case BULLET_TYPE.CHARGE_SHOOT:
                    bulletsmain = GameObject.Instantiate(bullet_charge) as GameObject;
                    bulletssub = GameObject.Instantiate(bullet_charge) as GameObject;
                    break;

            }

            // Rigidbodyに力を加えて発射
            bulletsmain.GetComponent<Rigidbody>().AddForce(mainGotoPosition * B_SPEED);
            bulletssub.GetComponent<Rigidbody>().AddForce(subGotoPosition * B_SPEED);

            // 弾丸の位置を調整
            bulletsmain.transform.position = muzzlemain.position;
            bulletssub.transform.position = muzzlesub.position;
        }

        void ChargeEfe()
        {
            ChargeSound.PlayOneShot(ChargeSound.clip);

            if (Time.timeScale == 0) ChargeSound.Stop();

            PM.ChargeShot.CS = true;
        }
    }
}