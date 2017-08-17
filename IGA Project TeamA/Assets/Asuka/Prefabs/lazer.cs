using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Shooting;

public class lazer : MonoBehaviour
{
    const float LAZER_ERASE_TIME = 1;
    const float LAZER_SPEED = 0.2f;
    bool lazerflg;
    float EraseRazerTimer;

    void Start()
    {
        lazerflg = true;
        EraseRazerTimer = 0;
        this.transform.localEulerAngles = Shooting_2.posi.transform.localEulerAngles;

    }

    void OnCollisionEnter(Collision collisions)
    {
        //if (collisions.gameObject.tag != "Player")
        //{
            lazerflg = false;
        //}
    }

    void Update()
    {
        if (lazerflg)
        {
            Shooting_2.b_main.gameObject.transform.localScale -= new Vector3(0, LAZER_SPEED, 0);
            Shooting_2.b_sub.gameObject.transform.localScale += new Vector3(0, LAZER_SPEED, 0);
        }
        else
        {
            EraseRazerTimer += Time.deltaTime;
            if (EraseRazerTimer > LAZER_ERASE_TIME)Destroy(this.gameObject);
        }
    }

 

}
