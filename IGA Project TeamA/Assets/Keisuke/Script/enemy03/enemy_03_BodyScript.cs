﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_03_BodyScript : MonoBehaviour 
{
    
    public static int e3_HP = 15;
    public const int Damage = 1;


    void Update()
    {
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet") 
        {
            GameObject.Destroy(collision.gameObject);
            e3_HP -= Damage;
        }
    }
}
