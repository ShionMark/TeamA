using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using enemys;
using Shooting;

public class enemy_03_weakness_01 : MonoBehaviour
{
    public static int e3_Weak01HP;

    void Start()
    {
        enemys.SpawnPoint_Behind.weak[1, 0] = this.gameObject;
        e3_Weak01HP = enemy_03_Script.ENEMY03_WEAK01_HP;
    }

    void OnCollisionEnter(Collision collision)
    {
        GameObject.Destroy(collision.gameObject);

        switch (collision.gameObject.tag)
        {
            case ("AutoBullet"):
                e3_Weak01HP -= Shooting.Shooting_2.AUTO_BULLET[Shooting_2.iNowBulletLevel] * 5;
                enemy_03_BodyScript.e3_HP -= Shooting.Shooting_2.AUTO_BULLET[Shooting_2.iNowBulletLevel] * 5;
                break;
            case ("Bullet"):
                e3_Weak01HP -= Shooting.Shooting_2.CHARGE_BULLET[Shooting_2.iNowBulletLevel] * 5;
                enemy_03_BodyScript.e3_HP -= Shooting.Shooting_2.CHARGE_BULLET[Shooting_2.iNowBulletLevel] * 5;
                break;

        }
    }
}

