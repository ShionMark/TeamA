using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using enemys;

public class enemy_02_weakness_01 : MonoBehaviour
{
    public static int e2_Weak01HP;

    void Start()
    {
        enemys.SpawnPoint_Behind.weak[0, 0] = this.gameObject;
        e2_Weak01HP = enemy_02_Script.ENEMY02_WEAK01_HP;
    }

    void OnCollisionEnter(Collision collision)
    {
        GameObject.Destroy(collision.gameObject);

        switch (collision.gameObject.tag)
        {
            case ("AutoBullet"):
                e2_Weak01HP -= Shooting.Shooting_2.AUTO_BULLET * 5;
                enemy_02_BodyScript.e2_HP -= Shooting.Shooting_2.AUTO_BULLET * 5;
                break;
            case ("Bullet"):
                e2_Weak01HP -= Shooting.Shooting_2.CHARGE_BULLET * 5;
                enemy_02_BodyScript.e2_HP -= Shooting.Shooting_2.CHARGE_BULLET * 5;
                break;

        }
    }
}
