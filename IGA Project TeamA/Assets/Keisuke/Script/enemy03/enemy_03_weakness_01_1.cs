using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using enemys;

public class enemy_03_weakness_01_1 : MonoBehaviour
{
    public static int e3_Weak01HP;

    void Start()
    {
        enemys.SpawnPoint_Behind.weak[1, 0] = this.gameObject;
        e3_Weak01HP = enemy_03_Script_1.ENEMY03_WEAK01_HP;
    }

    void OnCollisionEnter(Collision collision)
    {
        GameObject.Destroy(collision.gameObject);

        switch (collision.gameObject.tag)
        {
            case ("AutoBullet"):
                e3_Weak01HP -= Shooting.Shooting_2.AUTO_BULLET * 5;
                enemy_03_BodyScript_1.e3_HP -= Shooting.Shooting_2.AUTO_BULLET * 5;
                break;
            case ("Bullet"):
                e3_Weak01HP -= Shooting.Shooting_2.CHARGE_BULLET * 5;
                enemy_03_BodyScript_1.e3_HP -= Shooting.Shooting_2.CHARGE_BULLET * 5;
                break;

        }
    }
}

