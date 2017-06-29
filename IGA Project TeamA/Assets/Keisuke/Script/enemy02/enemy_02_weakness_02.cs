using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using enemys;

public class enemy_02_weakness_02 : MonoBehaviour
{
    public static int e2_Weak02HP;
    private int WeakDamage;

    void Start()
    {
        enemys.SpawnPoint_Behind.weak[0,1] = this.gameObject;
        e2_Weak02HP = 5;
        WeakDamage = enemy_02_BodyScript.Damage * 5;
    }

    void Update()
    {
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet") 
        {
            GameObject.Destroy(collision.gameObject);
            e2_Weak02HP -= WeakDamage;
            enemy_02_BodyScript.e2_HP -= WeakDamage;
        }
    }
}

