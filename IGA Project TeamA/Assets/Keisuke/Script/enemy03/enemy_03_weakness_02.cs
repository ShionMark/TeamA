using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using enemys;

public class enemy_03_weakness_02 : MonoBehaviour 
{
    public static int e3_Weak02HP;
    private int WeakDamage;

    void Start()
    {
        enemys.SpawnPoint_Behind.weak[1, 1] = this.gameObject;
        e3_Weak02HP = 25;
        WeakDamage = enemy_03_BodyScript.Damage * 5;
    }

    void Update()
    {
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet") 
        {
            GameObject.Destroy(collision.gameObject);
            e3_Weak02HP -= WeakDamage;
            enemy_03_BodyScript.e3_HP -= WeakDamage;
        }
    }
}
