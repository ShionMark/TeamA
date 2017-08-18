using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_04_BodyScript_1: MonoBehaviour
{

    void Start()
    {
        enemys.SpawnPoint_Behind.weak[2, 0] = null;
        enemys.SpawnPoint_Behind.weak[2, 1] = null;
    }

    public static int e4_HP = enemy_04_Script_1.ENEMY04_HP;

    void OnCollisionEnter(Collision collision)
    {
        GameObject.Destroy(collision.gameObject);
        switch (collision.gameObject.tag)
        {
            case ("AutoBullet"):
                e4_HP -= Shooting.Shooting_2.AUTO_BULLET;
                break;
            case ("Bullet"):
                e4_HP -= Shooting.Shooting_2.CHARGE_BULLET;
                break;

        }
    }
}