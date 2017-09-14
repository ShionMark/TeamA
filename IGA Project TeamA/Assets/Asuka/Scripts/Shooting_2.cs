using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PM;
using Sound;

namespace Shooting
{
    public class Shooting_2 : MonoBehaviour
    {
        const float LAZER_ERASE_TIME = 1;
        const float LAZER_SPEED = 0.2f;

        //弾丸の速度                                      Lv1  Lv2  Lv3  Lv4
        public readonly int[,] B_SPEED = new int[4, 4] {{ 100, 200, 100, 200 },        //バランス
                                                        { 100, 200, 100, 200 },        //パワー
                                                        { 100, 200, 100, 200 },        //スピード
                                                        { 100, 200, 100, 200 }};      //耐久

        //撃つ間隔（オートショットモード)                  Lv1 Lv2 Lv3 Lv4
        public readonly int[,] COUNTMAX = new int[4, 4] {{ 20, 20, 30, 30},    //バランス
                                                         { 20, 20, 30, 30},    //パワー
                                                         { 20, 20, 30, 30},    //スピード
                                                         { 20, 20, 30, 30}};   //耐久

        //オート弾の威力                                             Lv1 Lv2 Lv3 Lv4
        public static readonly int[,] AUTO_BULLET = new int[4, 4] {{ 100, 100, 1, 2},      //バランス
                                                                   { 100, 100, 1, 2},      //パワー
                                                                   { 100, 100, 1, 2},      //スピード
                                                                   { 100, 100, 1, 2}};     //耐久

        //チャージ弾の威力                                            Lv1 Lv2 Lv3  Lv4
        public static readonly int[,] CHARGE_BULLET = new int[4, 4] {{ 7, 12, 100, 100},        //バランス
                                                                     { 7, 12, 100, 100},        //パワー
                                                                     { 7, 12, 100, 100},        //スピード
                                                                     { 7, 12, 100, 100}};       //耐久

        public enum BULLET_TYPE { AUTO_SHOOT, CHARGE_SHOOT }
        //public BULLET_TYPE bullet_type;

        public GameObject bullet_auto, bullet_charge, razer_charge;
        public GameObject bulletsmain, bulletssub;

        public static GameObject b_main, b_sub;
        // 弾丸発射点
        public Transform muzzlemain, muzzlesub;
        //撃つ方向
        public Transform enemyposi, playerposi;

        public static Transform posi;

        public static bool LazerFlg, bPause;

        Vector3 subGotoPosition, mainGotoPosition;


        private int icount;//弾丸の間隔のカウント
        private bool isDoubleTapStart, isDoubleTap;//ダブルクリックのフラグ
        private float fdoubleTapTime; //タップ開始からの累積時間
        public static int iNowChar, iNowBulletLevel;


        private AudioSource ChargeSound;

        void Start()
        {
            LazerFlg = false;
            ChargeSound = GetComponent<AudioSource>();
            iNowChar = SelectManager.SelectMgr.iSelectJiki;
            iNowBulletLevel =
            icount = 0;
        }

        void Update()
        {
            if (bPause == false)
            {
                if (icount != COUNTMAX[iNowChar, iNowBulletLevel] && PM.ChargeShot.CS == false) icount++;

                if (LazerFlg)
                {
                    b_main.gameObject.transform.localScale -= new Vector3(0, LAZER_SPEED, 0);
                    b_sub.gameObject.transform.localScale += new Vector3(0, LAZER_SPEED, 0);
                }
                //------------------------------------------------------------------------------------------------

                //弾のエネルギー充填
                if (Input.GetMouseButtonUp(0) && isDoubleTap)
                {
                    if (!PM.ChargeShot.cs.isPlaying)        //弾充填が終わっていれば発射可能
                    {
                        if (iNowBulletLevel < 2)
                        {
                            Shoot(BULLET_TYPE.CHARGE_SHOOT);
                        }
                        else
                        {
                            lazer();
                        }

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

                if (!isDoubleTap && icount == COUNTMAX[Shooting_2.iNowChar, iNowBulletLevel])//オートショット
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
        }

        void Shoot(BULLET_TYPE bullet_type)
        {
            subGotoPosition = enemyposi.transform.position - muzzlesub.transform.position;
            mainGotoPosition = enemyposi.transform.position - muzzlemain.transform.position;

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
            bulletsmain.GetComponent<Rigidbody>().AddForce(mainGotoPosition * B_SPEED[Shooting_2.iNowChar, iNowBulletLevel]);
            bulletssub.GetComponent<Rigidbody>().AddForce(subGotoPosition * B_SPEED[Shooting_2.iNowChar, iNowBulletLevel]);

            // 弾丸の位置を調整
            bulletsmain.transform.position = muzzlemain.position;
            bulletssub.transform.position = muzzlesub.position;
        }

        void lazer()
        {
            posi = playerposi;

            subGotoPosition = muzzlesub.transform.position;
            mainGotoPosition = muzzlemain.transform.position;

            bulletsmain = GameObject.Instantiate(razer_charge) as GameObject;
            bulletssub = GameObject.Instantiate(razer_charge) as GameObject;

            b_main = bulletsmain;
            b_sub = bulletssub;

            bulletsmain.transform.position = muzzlemain.position;
            bulletssub.transform.position = muzzlesub.position;

            b_main.transform.localEulerAngles = Shooting_2.posi.transform.localEulerAngles;
            b_sub.transform.localEulerAngles = Shooting_2.posi.transform.localEulerAngles;

            LazerFlg = true;
        }

        void ChargeEfe()
        {
            ChargeSound.PlayOneShot(ChargeSound.clip);

            if (Time.timeScale == 0) ChargeSound.Stop();

            PM.ChargeShot.CS = true;
        }
    }
}