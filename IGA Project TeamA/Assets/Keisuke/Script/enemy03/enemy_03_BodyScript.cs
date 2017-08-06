using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_03_BodyScript : MonoBehaviour 
{

    public static int e3_HP = enemy_03_Script.ENEMY03_HP;

    void OnCollisionEnter(Collision collision)
    {
        GameObject.Destroy(collision.gameObject);
        switch (collision.gameObject.tag)
        {
            case ("AutoBullet"):
                e3_HP -= Shooting.Shooting_2.AUTO_BULLET;
                break;
            case ("Bullet"):
                e3_HP -= Shooting.Shooting_2.CHARGE_BULLET;
                break;

        }
    }
}