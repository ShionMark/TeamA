﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using enemys;
using PM;
using Sound;
using ItemMgr;
using Asuka;

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
            enemy_04_BodyScript.e4_HP = 15;

            Asuka.FuelBar2.bRecoFlg = true;
            ItemManager.bSpawnItemFlg = true;
            enemys.SpawnPoint_Behind.enemy[2].SetActive(false);
            PM.Body.EB = true;
            Sound.SoundSyastem.SoundOn = 5;     //効果音の番号
            // PM.PlayerMove.PMP = true;
            //enemys.SpawnPoint_Behind.EnemyGenerationFlg = true;  //敵沸処理
            // StageMove.BoxScript.ugoku = false;      //ステージを逆にスライドさせる
        }
    }
}
