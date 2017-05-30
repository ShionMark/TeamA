using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD:IGA Project TeamA/Assets/MainFolder/Asuka/Scripts/Shooting.cs
namespace Itsukit
=======
namespace Itsuki_ver1
>>>>>>> MainUpdate:IGA Project TeamA/Assets/0MainTest/BackUp/ver01/Asuka/Scripts/Shooting.cs
{
    public class Shooting : MonoBehaviour
    {
        // bullet prefab
        public GameObject bullet;
        // 弾丸発射点
        public Transform muzzlemain;
        public Transform muzzlesub;
        // 弾丸の速度
        public float speed = 1000;

        IEnumerator Start()
        {
            while (true)
            {
                // 弾丸の複製
                GameObject bulletsmain = GameObject.Instantiate(bullet) as GameObject;
                GameObject bulletssub = GameObject.Instantiate(bullet) as GameObject;

                // Rigidbodyに力を加えて発射
                bulletsmain.GetComponent<Rigidbody>().AddForce(Vector3.up * speed);
                bulletssub.GetComponent<Rigidbody>().AddForce(Vector3.down * speed);

                // 弾丸の位置を調整
                bulletsmain.transform.position = muzzlemain.position;
                bulletssub.transform.position = muzzlesub.position;

                yield return new WaitForSeconds(0.3f);
            }
        }

        // Update is called once per frame
        void Update()
        {
            //if (Input.GetKey(KeyCode.Z))
            //{

            //}
        }
    }
}