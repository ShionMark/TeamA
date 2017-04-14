using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Itsuki
{
    public class Bullet : MonoBehaviour
    {
        //オブジェクトが衝突したとき
        void OnCollisionEnter(Collision collisions)
        {
            Destroy(this.gameObject);
        }
    }
}