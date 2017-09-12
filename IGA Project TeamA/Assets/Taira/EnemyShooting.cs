using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Move;

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
        public Transform Mpos;

        public GameObject obj;
        ParticleSystem particle;
        //発射パターン
        public static int pattern = 0;

        public float speed;
        float time = 0;
        public float interval = 1f;


        // Use this for initialization
        void Start()
        {
            //particle.Stop();
        }

        // Update is called once per frame
        void Update()
        {
            time += Time.deltaTime;
            if (time > interval)
            {
                
                switch (pattern)
                {
                    case 0:
                        ShotL();
                        ShotR();
                        pattern = 1;
                        break;
                    case 1:
                        ShotU();
                        ShotD();
                        pattern = 0;
                        break;
                    case 2:
                        MaSpa();
                        pattern = 3;
                        break;
                    case 3:
                        MaSpa();
                        pattern = 0;
                        break;
                }
                time = 0;
                
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
        void MaSpa()
        {
            if (pattern == 2)
            {
                obj = GameObject.Find("MasterSpark");
                particle = obj.GetComponent<ParticleSystem>();
                particle.transform.position = Mpos.position;
                // ここで Particle System を開始します.
                particle.Play();
            }
            else
            {
                obj = GameObject.Find("MasterSpark");
                particle = obj.GetComponent<ParticleSystem>();
                // ここで Particle System を開始します.
                particle.Stop();
            }
        }
    }
}