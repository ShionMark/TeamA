using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using enemys;
using Shooting;

public class enemy_02_weakness_01_1 : MonoBehaviour
{
    public static int e2_Weak01HP;

    void Start()
    {
        enemys.SpawnPoint_Behind.weak[0, 0] = this.gameObject;
        e2_Weak01HP = enemy_02_Script_1.ENEMY02_WEAK01_HP;
    }

    void OnCollisionEnter(Collision collision)
    {
        GameObject.Destroy(collision.gameObject);

        switch (collision.gameObject.tag)
        {
            case ("AutoBullet"):
                e2_Weak01HP -= Shooting.Shooting_2.AUTO_BULLET[Shooting_2.iNowChar, Shooting_2.iNowBulletLevel] * 5;
                enemy_02_BodyScript_1.e2_HP -= Shooting.Shooting_2.AUTO_BULLET[Shooting_2.iNowChar, Shooting_2.iNowBulletLevel] * 5;
                break;
            case ("Bullet"):
                e2_Weak01HP -= Shooting.Shooting_2.CHARGE_BULLET[Shooting_2.iNowChar, Shooting_2.iNowBulletLevel] * 5;
                enemy_02_BodyScript_1.e2_HP -= Shooting.Shooting_2.CHARGE_BULLET[Shooting_2.iNowChar, Shooting_2.iNowBulletLevel] * 5;
                break;

        }
    }
}
