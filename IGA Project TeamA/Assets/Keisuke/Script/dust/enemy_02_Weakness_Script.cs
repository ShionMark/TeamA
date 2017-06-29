using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_02_Weakness_Script : MonoBehaviour {

    private int e2_WeakHP;
    private int WeakDamage;

    void Start()
    {
        e2_WeakHP = 25;
        WeakDamage = enemy_02_BodyScript.Damage * 5;
    }


    void Update()
    {
        if (enemy_02_BodyScript.e2_HP <= 0 || e2_WeakHP <= 0)
        {
            e2_WeakHP = 25;
            this.gameObject.SetActive(false);
        }
    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Fallingobject")
        {
            GameObject.Destroy(collision.gameObject);

            e2_WeakHP -= WeakDamage;
            enemy_02_BodyScript.e2_HP -= WeakDamage;
        }
    }
}
