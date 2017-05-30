using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using enemys;

public class enemy_04_Script : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        enemys.SpawnPoint_Behind.enemy[2] = this.gameObject;

        enemys.SpawnPoint_Behind.enemy[2].SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        //エネミー03のHPがなくなったときの処理
        if (enemy_04_BodyScript.e4_HP <= 0)
        {
            enemy_04_BodyScript.e4_HP = 50;

            enemys.SpawnPoint_Behind.EnemyGenerationFlg = true;
            enemys.SpawnPoint_Behind.enemy[2].SetActive(false);
        }
    }
}
