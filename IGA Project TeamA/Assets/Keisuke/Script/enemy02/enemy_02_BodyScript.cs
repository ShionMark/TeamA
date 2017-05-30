using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_02_BodyScript : MonoBehaviour
{

    public static int e2_HP;
    public static int Damage;

    void Start()
    {
        e2_HP = 50;
        Damage = 5;
    }

    void Update()
    {
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Fallingobject")
        {
            GameObject.Destroy(collision.gameObject);
            e2_HP -= Damage;
        }
    }
}