using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using enemys;
public class enemy_03_weakness_01 : MonoBehaviour
{
        
    public static int e3_Weak01HP;
    private int WeakDamage;

    void Start()
    {
        enemys.SpawnPoint_Behind.weak[1,0] = this.gameObject;
        e3_Weak01HP = 5;
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
            e3_Weak01HP -= WeakDamage;
            enemy_03_BodyScript.e3_HP -= WeakDamage;
           
        }
    }
}
