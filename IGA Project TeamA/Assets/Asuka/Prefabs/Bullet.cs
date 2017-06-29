using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD
namespace Itsuki
{
    public class Bullet : MonoBehaviour
    {
        //オブジェクトが衝突したとき
        void OnCollisionEnter(Collision collisions)
        {
=======
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
           if (collisions.gameObject.tag != "Player") 
>>>>>>> origin/master
            Destroy(this.gameObject);
        }
    }
}