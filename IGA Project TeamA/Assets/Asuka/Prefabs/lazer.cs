using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Shooting;

public class lazer : MonoBehaviour
{
    void OnCollisionEnter(Collision collisions)
    {
        Destroy(Shooting_2.b_main.gameObject);
        Destroy(Shooting_2.b_sub.gameObject);
        Shooting_2.LazerFlg = false;
    }
}
