using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using enemys;
using Shooting;

public class enemy_03_weakness_02 : MonoBehaviour 
{
    public static int e3_Weak02HP;

    void Start()
    {
        enemys.SpawnPoint_Behind.weak[1, 1] = this.gameObject;
        e3_Weak02HP = enemy_03_Script.ENEMY03_WEAK02_HP;
    }

    void OnCollisionEnter(Collision collision)
    {
        GameObject.Destroy(collision.gameObject);

        switch (collision.gameObject.tag)
        {
            case ("AutoBullet"):
                e3_Weak02HP -= Shooting.Shooting_2.AUTO_BULLET[Shooting_2.iNowBulletLevel] * 5;
                enemy_03_BodyScript.e3_HP -= Shooting.Shooting_2.AUTO_BULLET[Shooting_2.iNowBulletLevel] * 5;
                break;
            case ("Bullet"):
                e3_Weak02HP -= Shooting.Shooting_2.CHARGE_BULLET[Shooting_2.iNowBulletLevel] * 5;
                enemy_03_BodyScript.e3_HP -= Shooting.Shooting_2.CHARGE_BULLET[Shooting_2.iNowBulletLevel] * 5;
                break;

        }
    }
}