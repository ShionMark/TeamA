using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Shooting;

public class enemy_02_BodyScript_1 : MonoBehaviour
{

    public static int e2_HP = enemy_02_Script_1.ENEMY02_HP;

    void OnCollisionEnter(Collision collision)
    {
        GameObject.Destroy(collision.gameObject);
        switch (collision.gameObject.tag)
        {
            case ("AutoBullet"):
                e2_HP -= Shooting.Shooting_2.AUTO_BULLET;
                break;
            case ("Bullet"):
                e2_HP -= Shooting.Shooting_2.CHARGE_BULLET;
                break;

        }
    }
}