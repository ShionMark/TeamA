using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using enemys;

public class enemy_02_weakness_02 : MonoBehaviour
{
    public static int e2_Weak02HP;
    //private int WeakDamage; //= enemy_02_BodyScript.Damage * 5;

    void Start()
    {
        enemys.SpawnPoint_Behind.weak[0, 1] = this.gameObject;
        e2_Weak02HP = enemy_02_Script.ENEMY02_WEAK02_HP;
        // WeakDamage = enemy_02_BodyScript.Damage* 5;
    }


    void OnCollisionEnter(Collision collision)
    {
        GameObject.Destroy(collision.gameObject);

        switch (collision.gameObject.tag)
        {
            case ("AutoBullet"):
                e2_Weak02HP -= Shooting.Shooting_2.AUTO_BULLET * 5;
                enemy_02_BodyScript.e2_HP -= Shooting.Shooting_2.AUTO_BULLET * 5;
                break;
            case ("Bullet"):
                e2_Weak02HP -= Shooting.Shooting_2.CHARGE_BULLET * 5;
                enemy_02_BodyScript.e2_HP -= Shooting.Shooting_2.CHARGE_BULLET * 5;
                break;

        }
    }
}
