﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using enemys;
using score;
using StageMove;
using PM;
using Sound;
using Asuka;

public class enemy_03_Script : MonoBehaviour
{
    public const int ENEMY03_HP = 100;
    public const int ENEMY03_WEAK01_HP = 35;
    public const int ENEMY03_WEAK02_HP = 35;

    // Use this for initialization
    void Start()
    {
        enemys.SpawnPoint_Behind.enemy[1] = this.gameObject;
        enemys.SpawnPoint_Behind.enemy[1].SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        //weak01のHPがなくなったときの処理
        if (enemy_03_weakness_01.e3_Weak01HP <= 0)
        {
            enemy_03_weakness_01.e3_Weak01HP = ENEMY03_WEAK01_HP;
            enemys.SpawnPoint_Behind.weak[1, 0].SetActive(false);
        }
        //weak02のHPがなくなったときの処理
        if (enemy_03_weakness_02.e3_Weak02HP <= 0)
        {
            enemy_03_weakness_02.e3_Weak02HP = ENEMY03_WEAK02_HP;
            enemys.SpawnPoint_Behind.weak[1, 1].SetActive(false);
        }

        //エネミー03のHPがなくなったときの処理
        if (enemy_03_BodyScript.e3_HP <= 0)
        {
            Asuka.FuelBar2.bRecoFlg = true;
            enemy_03_BodyScript.e3_HP = ENEMY03_HP;
            enemy_03_weakness_01.e3_Weak01HP = ENEMY03_WEAK01_HP;
            enemy_03_weakness_02.e3_Weak02HP = ENEMY03_WEAK02_HP;
            score.ScoreNumber.ScorePlusFlg = true;
            enemys.SpawnPoint_Behind.enemy[1].SetActive(false);
            PM.Body.EB = true;
            Sound.SoundSyastem.SoundOn = 5;     //効果音の番号
            // PM.PlayerMove.PMP = true;
            // enemys.SpawnPoint_Behind.EnemyGenerationFlg = true;
            // StageMove.BoxScript.ugoku = false;      //ステージを逆にスライドさせる。
        }
    }
}