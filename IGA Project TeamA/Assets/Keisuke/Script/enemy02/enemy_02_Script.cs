using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using enemys;
using Asuka;
public class enemy_02_Script : MonoBehaviour
{
    
    // Use this for initialization
    void Start()
    {
       

        enemys.SpawnPoint_Behind.enemy[0] = this.gameObject;
        enemys.SpawnPoint_Behind.enemy[0].SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        //weak01のHPがなくなったときの処理
        if (enemy_02_weakness_01.e2_Weak01HP <= 0)
        {
            enemy_02_weakness_01.e2_Weak01HP = 25;
            enemys.SpawnPoint_Behind.weak[0, 0].SetActive(false);
        }
        //weak02のHPがなくなったときの処理
        if (enemy_02_weakness_02.e2_Weak02HP <= 0)
        {
            enemy_02_weakness_02.e2_Weak02HP = 25;
            enemys.SpawnPoint_Behind.weak[0, 1].SetActive(false);
        }
        //エネミー02のHPがなくなったときの処理
        if (enemy_02_BodyScript.e2_HP <= 0)
        {
           
            enemy_02_BodyScript.e2_HP = 50;
            enemy_02_weakness_01.e2_Weak01HP = 25;
            enemy_02_weakness_02.e2_Weak02HP = 25;
            enemys.SpawnPoint_Behind.EnemyGenerationFlg = true;
            Asuka.Score.ScoreFlg = true;
            enemys.SpawnPoint_Behind.enemy[0].SetActive(false);
        }
    }
}