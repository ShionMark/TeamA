using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Itsuki
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


        void Start()
        {
            count = 10;
        }

        void Update()
        {
            if (count != 10) count++;

            if (Input.GetMouseButton(0) && count == 10)
            {
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

                count = 0;
            }
        }
    }
}