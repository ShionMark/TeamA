using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_02_BodyScript : MonoBehaviour
{

    public static int e2_HP  = 15;
    public const int Damage  = 1;

    void Start()
    {
    }

    void Update()
    {
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet") 
        {
            GameObject.Destroy(collision.gameObject);
            e2_HP -= Damage;
        }
    }
}