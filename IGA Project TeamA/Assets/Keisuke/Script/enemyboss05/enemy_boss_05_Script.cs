using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using enemys;
using PM;
using Sound;
using ItemMgr;
using Asuka;
using StageMgr;

public class enemy_boss_05_Script : MonoBehaviour
{
    public const int ENEMY_BOSS_05_HP = 1000;

    // Use this for initialization
    void Start()
    {
        enemys.SpawnPoint_Behind.enemy[7] = this.gameObject;
        enemys.SpawnPoint_Behind.enemy[7].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        BossMove.MoveEnemyBoss.Move_Pattern = 5;
        //エネミーボス01のHPがなくなったときの処理
        if (enemy_boss_05_BodyScript.eb_5_HP <= 0)
        {
            enemy_boss_05_BodyScript.eb_5_HP = ENEMY_BOSS_05_HP;

            Asuka.FuelBar2.bRecoFlg = true;
            ItemManager.bSpawnItemFlg = true;
            enemys.SpawnPoint_Behind.enemy[7].SetActive(false);
            PM.Body.EB = true;
            //StageManager.IntervalType = StageManager.INTERVAL_TYPE.INTERVAL_CLEAR;
            SceneManager.LoadScene("GameClearScene");
            Sound.SoundSyastem.SoundOn = 5;     //効果音の番号
            // PM.PlayerMove.PMP = true;
            //enemys.SpawnPoint_Behind.EnemyGenerationFlg = true;  //敵沸処理
            // StageMove.BoxScript.ugoku = false;      //ステージを逆にスライドさせる
        }
    }
}
