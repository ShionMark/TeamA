using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Shooting;

public class enemy_04_BodyScript : MonoBehaviour
{

    void Start()
    {
        enemys.SpawnPoint_Behind.weak[2, 0] = null;
        enemys.SpawnPoint_Behind.weak[2, 1] = null;
    }

    public static int e4_HP = enemy_04_Script.ENEMY04_HP;

    void OnCollisionEnter(Collision collision)
    {
        GameObject.Destroy(collision.gameObject);
        switch (collision.gameObject.tag)
        {
            case ("AutoBullet"):
                e4_HP -= Shooting.Shooting_2.AUTO_BULLET[Shooting_2.iNowBulletLevel];
                break;
            case ("Bullet"):
                e4_HP -= Shooting.Shooting_2.CHARGE_BULLET[Shooting_2.iNowBulletLevel];
                Debug.Log("180sx");
                break;

        }
    }
}