using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using enemys;
using PM;
using Sound;
using score;
using Asuka;
using StageMgr;

public class enemy_boss_01_Script : MonoBehaviour
{
    public const int ENEMY_BOSS_01_HP = 100;

    // Use this for initialization
    void Start()
    {
        enemys.SpawnPoint_Behind.enemy[3] = this.gameObject;
        enemys.SpawnPoint_Behind.enemy[3].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //エネミーボス01のHPがなくなったときの処理
        if (enemy_boss_01_BodyScript.eb_1_HP <= 0)
        {
            enemy_boss_01_BodyScript.eb_1_HP = ENEMY_BOSS_01_HP;

            Asuka.FuelBar2.bRecoFlg = true;
            score.ScoreNumber.ScorePlusFlg = true;
            enemys.SpawnPoint_Behind.enemy[3].SetActive(false);
            PM.Body.EB = true;
            StageManager.IntervalType = StageManager.INTERVAL_TYPE.INTERVAL_CLEAR;
            Sound.SoundSyastem.SoundOn = 5;     //効果音の番号
            // PM.PlayerMove.PMP = true;
            //enemys.SpawnPoint_Behind.EnemyGenerationFlg = true;  //敵沸処理
            // StageMove.BoxScript.ugoku = false;      //ステージを逆にスライドさせる
        }
    }
}
