using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Move;
using Shooting;
namespace Taira
{
    public class EnemyShooting : MonoBehaviour
    {

        //弾のプレハブ
        public GameObject Bullet;
        //弾の発射点
        public Transform PosR;
        public Transform PosL;
        public Transform PosU;
        public Transform PosD;

        public GameObject Masupa_D;
        public GameObject Masupa_U;
        public GameObject Masupa_L;
        public GameObject Masupa_R;
        public float Masupa_WaitTime = 0f;
        float Elapsedtime = 0f;


        ParticleSystem particle;
        public static int pattern = 0;

        public float speed;
        float Shoot_time = 0;
        public float interval = 1f;
        public int ShootingPattern; //シューティングパターン

        // Use this for initialization
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
            if (!Shooting.Shooting_2.bPause)
            {
                switch (ShootingPattern)
                {
                    case 1:


                        if (Shoot_time > interval)
                        {
                            ShotL();
                            ShotR();
                            ShotU();
                            ShotD();
                            Shoot_time = 0;
                        }
                        else
                        {
                            Shoot_time += Time.deltaTime;
                        }

                        break;

                    case 2:

                        if (Shoot_time > interval)
                        {
                            ShotL();
                            ShotR();

                            Shoot_time = 0;
                        }
                        else
                        {
                            Shoot_time += Time.deltaTime;
                        }

                        break;

                    case 3:

                        if (Shoot_time > interval)
                        {
                            ShotD();
                            ShotU();

                            Shoot_time = 0;
                        }
                        else
                        {
                            Shoot_time += Time.deltaTime;
                        }

                        break;
                    case 4:


                        if (Shoot_time > interval)
                        {
                            ShotL();
                            ShotR();
                            ShotU();
                            ShotD();
                            Shoot_time = 0;
                        }
                        else
                        {
                            Shoot_time += Time.deltaTime;
                        }

                        if (Elapsedtime >= Masupa_WaitTime)
                        {

                            MaSpa_D();
                            MaSpa_U();
                            MaSpa_L();
                            MaSpa_R();

                            Elapsedtime = 0;
                        }
                        else
                        {
                            Elapsedtime += Time.deltaTime;
                        }
                        break;

                    case 5:


                        if (Shoot_time > interval)
                        {
                            ShotL();
                            ShotR();
                            ShotU();

                            Shoot_time = 0;
                        }
                        else
                        {
                            Shoot_time += Time.deltaTime;
                        }

                        if (Elapsedtime >= Masupa_WaitTime)
                        {

                            MaSpa_U();
                            MaSpa_L();
                            MaSpa_R();

                            Elapsedtime = 0;
                        }
                        else
                        {
                            Elapsedtime += Time.deltaTime;
                        }
                        break;

                }
            }
        }

        void ShotL()
        {
            // 弾丸の複製
            GameObject bullets = GameObject.Instantiate(Bullet) as GameObject;

            Vector3 force;
            force = this.gameObject.transform.right * speed;
            // Rigidbodyに力を加えて発射
            bullets.GetComponent<Rigidbody>().AddForce(-(force));
            // 弾丸の位置を調整
            bullets.transform.position = PosL.position;
        }

        void ShotR()
        {
            // 弾丸の複製
            GameObject bullets = GameObject.Instantiate(Bullet) as GameObject;

            Vector3 force;
            force = this.gameObject.transform.right * speed;
            // Rigidbodyに力を加えて発射
            bullets.GetComponent<Rigidbody>().AddForce(force);
            // 弾丸の位置を調整
            bullets.transform.position = PosR.position;
        }

        void ShotU()
        {
            // 弾丸の複製
            GameObject bullets = GameObject.Instantiate(Bullet) as GameObject;

            Vector3 force;
            force = this.gameObject.transform.up * speed;
            // Rigidbodyに力を加えて発射
            bullets.GetComponent<Rigidbody>().AddForce(force);
            // 弾丸の位置を調整
            bullets.transform.position = PosU.position;
        }

        void ShotD()
        {
            //弾丸の複製
            GameObject bullets = GameObject.Instantiate(Bullet) as GameObject;

            Vector3 force;
            force = this.gameObject.transform.up * speed;
            //Rigitbodyに力を加えて発射
            bullets.GetComponent<Rigidbody>().AddForce(-(force));
            //弾丸の位置の調整
            bullets.transform.position = PosD.position;
        }
        void MaSpa_D()
        {
            particle = Masupa_D.GetComponent<ParticleSystem>();
            particle.transform.position = PosD.position;
            particle.Play();

        }

        void MaSpa_U()
        {

            particle = Masupa_U.GetComponent<ParticleSystem>();
            particle.transform.position = PosU.position;
            particle.Play();
        }

        void MaSpa_L()
        {

            particle = Masupa_L.GetComponent<ParticleSystem>();
            particle.transform.position = PosL.position;
            particle.Play();
        }

        void MaSpa_R()
        {

            particle = Masupa_R.GetComponent<ParticleSystem>();
            particle.transform.position = PosR.position;
            particle.Play();
        }


    }
}