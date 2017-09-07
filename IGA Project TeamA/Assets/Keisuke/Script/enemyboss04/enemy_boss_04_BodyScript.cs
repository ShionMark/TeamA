using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Shooting;

public class enemy_boss_04_BodyScript : MonoBehaviour
{

    void Start()
    {
        enemys.SpawnPoint_Behind.weak[6, 0] = null;
        enemys.SpawnPoint_Behind.weak[6, 1] = null;
    }

    public static int eb_4_HP = enemy_boss_04_Script.ENEMY_BOSS_04_HP;

    void OnCollisionEnter(Collision collision)
    {
        GameObject.Destroy(collision.gameObject);
        switch (collision.gameObject.tag)
        {
            case ("AutoBullet"):
                eb_4_HP -= Shooting.Shooting_2.AUTO_BULLET[Shooting_2.iNowChar, Shooting_2.iNowBulletLevel];
                break;
            case ("Bullet"):
                eb_4_HP -= Shooting.Shooting_2.CHARGE_BULLET[Shooting_2.iNowChar, Shooting_2.iNowBulletLevel];
                break;

        }
    }
}