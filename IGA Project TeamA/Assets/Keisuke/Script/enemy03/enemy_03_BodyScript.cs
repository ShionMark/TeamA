﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_03_BodyScript : MonoBehaviour 
{

    public static int e3_HP;
    public static int Damage;

    void Start()
    {
        e3_HP = 50;
        Damage = 5;
    }

    void Update()
    {
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Fallingobject")
        {
            GameObject.Destroy(collision.gameObject);
            e3_HP -= Damage;
        }
    }
}
