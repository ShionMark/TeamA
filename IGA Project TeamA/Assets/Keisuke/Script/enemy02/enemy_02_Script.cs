using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using enemys;
using StageMove;
using PM;
using Sound;
using ItemMgr;
using Asuka;
using StageMgr;

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
            enemy_02_weakness_01.e2_Weak01HP = 5;
            enemys.SpawnPoint_Behind.weak[0, 0].SetActive(false);
            PM.weakness01.WNP01 = true;
        }
        //weak02のHPがなくなったときの処理
        if (enemy_02_weakness_02.e2_Weak02HP <= 0)
        {
            enemy_02_weakness_02.e2_Weak02HP = 5;
            enemys.SpawnPoint_Behind.weak[0, 1].SetActive(false);
            PM.weakness02.WNP02 = true;
        }
        //エネミー02のHPがなくなったときの処理
        if (enemy_02_BodyScript.e2_HP <= 0)
        {
            Asuka.FuelBar2.bRecoFlg = true;
            enemy_02_BodyScript.e2_HP = 15;
            enemy_02_weakness_01.e2_Weak01HP = 5;
            enemy_02_weakness_02.e2_Weak02HP = 5;
            ItemManager.bSpawnItemFlg = true;
            enemys.SpawnPoint_Behind.enemy[0].SetActive(false);
            PM.Body.EB = true;
            StageManager.bCreateEnemyFlg = true;
            Sound.SoundSyastem.SoundOn = 5;     //効果音の番号
            // PM.PlayerMove.PMP = true;
            // enemys.SpawnPoint_Behind.EnemyGenerationFlg = true;
            // StageMove.BoxScript.ugoku = false;      //ステージを逆にスライドさせる
        }
    }
}