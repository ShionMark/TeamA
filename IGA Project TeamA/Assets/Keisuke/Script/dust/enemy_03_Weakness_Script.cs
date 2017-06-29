using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_03_Weakness_Script : MonoBehaviour {

    public static int e3_WeakHP;
    private int WeakDamage;
    void Start()
    {
        e3_WeakHP = 25;
        WeakDamage = enemy_03_BodyScript.Damage * 5;
    }


    void Update()
    {
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Fallingobject")
        {
            GameObject.Destroy(collision.gameObject);
            e3_WeakHP -= WeakDamage;
            enemy_03_BodyScript.e3_HP -= WeakDamage;
        }
    }
}
