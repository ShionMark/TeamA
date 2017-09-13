using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Shooting;
using enemys;
using StageBGM;
using StageMove;

namespace StageMgr
{
    public class StageManager : MonoBehaviour
    {
        private const int START_INTERVAL_TIME = 380;
        private const int CLEAR_INTERVAL_TIME = 380;
        private const int CREATE_ENEMY_TIME = 380;

        public Button IntervalNextButton, IntervalEndButton;
        public GameObject IntervalBack, IntervalClearText, IntervalStartText, IntervalButtons;
        public GameObject[] IntervalStageText;

        public static bool bCreateEnemyFlg;
        public static int iNowStage;

        public string text = "TitleScene";

        private int iIntervalCount, i_E_C_Count;

        private bool ButtonFlg;

        public static bool aikonMoveFlg; 

        public enum INTERVAL_TYPE { INTERVAL_START, INTERVAL_CLEAR, UN_INTERVAL }
        public static INTERVAL_TYPE IntervalType;

        // Use this for initialization
        void Start()
        {
            Button NextButton = IntervalNextButton.GetComponent<Button>();
            NextButton.onClick.AddListener(NextButtonOnClick);

            Button EndButton = IntervalEndButton.GetComponent<Button>();//スタート(ポーズ中）
            EndButton.onClick.AddListener(EndButtonOnClick);

            iNowStage = SelectManager.SelectMgr.iSelectStage;
            iIntervalCount = 0;

            ButtonFlg = false;
            aikonMoveFlg = false;

            i_E_C_Count = CREATE_ENEMY_TIME;

            IntervalType = INTERVAL_TYPE.INTERVAL_START;

            IntervalBack.SetActive(true);　　　　　　　    //半透明な背景を映す
            IntervalStartText.SetActive(true);　　　　　　 //ステージスタートの文字を映す
            IntervalClearText.SetActive(false);            //ステージクリアの文字を消す
            IntervalButtons.SetActive(false);              //ボタンを消す
            IntervalStageText[iNowStage].SetActive(true);  //今のステージの文字を映す

            for (int i = 0; i <= 4; i++)//それ以外のステージの文字を消す
            {
                if (i != iNowStage) IntervalStageText[i].SetActive(false);
            }
        }

        // Update is called once per frame
        void Update()
        {

            if (bCreateEnemyFlg)
            {
                aikonMoveFlg = true;
                if (--i_E_C_Count < 0)
                {
                    aikonMoveFlg = false;
                    bCreateEnemyFlg = false;
                    i_E_C_Count = CREATE_ENEMY_TIME;
                    BoxScript.ugoku =
                    enemys.SpawnPoint_Behind.EnemyGenerationFlg = true;
                }
            }


            switch (IntervalType)
            {
                case INTERVAL_TYPE.INTERVAL_START://スタートのインターバル
                    OnStartInterval();
                    break;
                case INTERVAL_TYPE.INTERVAL_CLEAR://ステージクリアのインターバル
                    OnClearInterval();
                    break;
                case INTERVAL_TYPE.UN_INTERVAL://インターバルじゃないとき
                    OnUnInterval();
                    break;
            }
        }

        void NextButtonOnClick()
        {
            Sound.SoundSyastem.SoundOn = 0;
            ButtonFlg = true;
        }

        void EndButtonOnClick()
        {
            Sound.SoundSyastem.SoundOn = 0;
            SceneManager.LoadScene(text);
        }

        private void OnStartInterval() // スタートインターバル実行中
        {

            Time.timeScale = 0;
            Shooting_2.bPause = true;
            if (++iIntervalCount > START_INTERVAL_TIME)//インターバルの時間のカウント
            {
                Switching(0);
                IntervalType = INTERVAL_TYPE.UN_INTERVAL;
            }
        }

        private void OnClearInterval() // クリアインターバル実行中
        {
            IntervalStageText[iNowStage].SetActive(true);
            IntervalBack.SetActive(true);              //半透明な背景を映す
            IntervalClearText.SetActive(true);         //ステージクリアの文字を映す
            IntervalButtons.SetActive(true);          //ボタンを映す

            Time.timeScale = 0;
            Shooting_2.bPause = true;

            if (ButtonFlg)//インターバルの時間のカウント
            {
                ButtonFlg = false;
                StageBGM.MainBGMSoundSystem.BGM_Change = true;
                StageBGM.MainBGMSoundSystem.StageBGM_number++;
                iNowStage++;
                Switching(1);

                //SpawnPoint_Behind.SpawnEnemyCount =
                iIntervalCount = 0;

                BoxScript.ugoku =
                enemys.SpawnPoint_Behind.EnemyGenerationFlg = true;

                IntervalType = INTERVAL_TYPE.INTERVAL_START;
            }
        }

        private void OnUnInterval() // インターバル未実行
        {
            Time.timeScale = 1;
            Shooting_2.bPause = false;

        }

        private void Switching(int j)
        {

            iIntervalCount = 0;//インターバルの時間の初期化

            switch (j)
            {
                case 0://全部消す
                    IntervalBack.SetActive(false);　　　   　　　　//半透明な背景を映す
                    IntervalClearText.SetActive(false);            //ステージクリアの文字を消す
                    IntervalStartText.SetActive(false);            //ステージスタートの文字を消す
                    IntervalButtons.SetActive(false);              //ボタンを消す
                    IntervalStageText[iNowStage].SetActive(false); //今のステージの文字を消す
                    for (int i = 0; i <= 4; i++)//それ以外のステージの文字を消す
                    {
                        IntervalStageText[i].SetActive(false);
                    }
                    break;
                case 1:
                    IntervalBack.SetActive(true);　　　　　　　    //半透明な背景を映す
                    IntervalStartText.SetActive(true);            //ステージスタートの文字を映す
                    IntervalClearText.SetActive(false);            //ステージクリアの文字を消す
                    IntervalStageText[iNowStage].SetActive(true);  //今のステージの文字を映す
                    IntervalButtons.SetActive(false);              //ボタンを消す
                    for (int i = 0; i <= 4; i++)//それ以外のステージの文字を消す
                    {
                        if (i != iNowStage) IntervalStageText[i].SetActive(false);
                    }
                    break;


            }
        }
    }
}