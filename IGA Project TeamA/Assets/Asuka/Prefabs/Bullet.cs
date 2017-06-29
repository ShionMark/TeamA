using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Itsuki_ver1
{
    public class Bullet : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

      //オブジェクトが衝突したとき
        void OnCollisionEnter(Collision collisions)
        {
            if (collisions.gameObject.tag != "Player" 
                || this.gameObject.transform.position.x >= 100 
                || this.gameObject.transform.position.x <= -100
                || this.gameObject.transform.position.y >= 100
                || this.gameObject.transform.position.y <= -100)
            Destroy(this.gameObject);
        }
    }
}