using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Shooting;

public class enemy_boss_02_BodyScript : MonoBehaviour
{

    void Start()
    {
        enemys.SpawnPoint_Behind.weak[4, 0] = null;
        enemys.SpawnPoint_Behind.weak[4, 1] = null;
    }

    public static int eb_2_HP = enemy_boss_02_Script.ENEMY_BOSS_02_HP;

    void OnCollisionEnter(Collision collision)
    {
        GameObject.Destroy(collision.gameObject);
        switch (collision.gameObject.tag)
        {
            case ("AutoBullet"):
                eb_2_HP -= Shooting.Shooting_2.AUTO_BULLET[Shooting_2.iNowBulletLevel];
                break;
            case ("Bullet"):
                eb_2_HP -= Shooting.Shooting_2.CHARGE_BULLET[Shooting_2.iNowBulletLevel];
                break;

        }
    }
}