using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_04_BodyScript : MonoBehaviour
{

    public static int e4_HP = 15;
    public static int Damage = 5;

    void Start()
    {
        enemys.SpawnPoint_Behind.weak[2, 0] = null;
        enemys.SpawnPoint_Behind.weak[2, 1] = null;
        //e4_HP = 15;
        //Damage = 5;
    }

    void Update()
    {
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet") 
        {
            GameObject.Destroy(collision.gameObject);
            e4_HP -= Damage;
        }
    }
}
