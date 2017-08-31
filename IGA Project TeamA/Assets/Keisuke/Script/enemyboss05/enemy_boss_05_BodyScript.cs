using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Shooting;

public class enemy_boss_05_BodyScript : MonoBehaviour
{

    void Start()
    {
        enemys.SpawnPoint_Behind.weak[7, 0] = null;
        enemys.SpawnPoint_Behind.weak[7, 1] = null;
    }

    public static int eb_5_HP = enemy_boss_05_Script.ENEMY_BOSS_05_HP;

    void OnCollisionEnter(Collision collision)
    {
        GameObject.Destroy(collision.gameObject);
        switch (collision.gameObject.tag)
        {
            case ("AutoBullet"):
                eb_5_HP -= Shooting.Shooting_2.AUTO_BULLET[Shooting_2.iNowBulletLevel];
                break;
            case ("Bullet"):
                eb_5_HP -= Shooting.Shooting_2.CHARGE_BULLET[Shooting_2.iNowBulletLevel];
                break;

        }
    }
}