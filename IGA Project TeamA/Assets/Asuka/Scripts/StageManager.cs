using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Shooting;
using enemys;
using StageMove;

namespace StageMgr
{
    public class StageManager : MonoBehaviour
    {

        public GameObject IntervalBack, IntervalStage1, IntervalClear;
        public static bool bCreateEnemyFlg;
        private int iIntervalCount, i_E_C_Count;
        public static int iNowStage;
        public enum INTERVAL_TYPE { INTERVAL_START, INTERVAL_CLEAR, UN_INTERVAL }
        public static INTERVAL_TYPE IntervalType;

        // Use this for initialization
        void Start()
        {
            iNowStage = 0;
            i_E_C_Count = 380;
            IntervalType = INTERVAL_TYPE.INTERVAL_START;
            iIntervalCount = 0;
        }

        // Update is called once per frame
        void Update()
        {

            if (bCreateEnemyFlg)
            {
                if (--i_E_C_Count < 0)
                {
                    bCreateEnemyFlg = false;
                    i_E_C_Count = 380;
                    BoxScript.ugoku =
                    enemys.SpawnPoint_Behind.EnemyGenerationFlg = true;
                }
            }


            switch (IntervalType)
            {
                case INTERVAL_TYPE.INTERVAL_START:
                    OnStartInterval();
                    break;
                case INTERVAL_TYPE.INTERVAL_CLEAR:
                    OnClearInterval();
                    break;
                case INTERVAL_TYPE.UN_INTERVAL:
                    OnUnInterval();
                    break;
            }
        }

        public void OnStartInterval() // インターバル実行中
        {

            IntervalBack.SetActive(true);
            IntervalStage1.SetActive(true);
            IntervalClear.SetActive(false);
            Time.timeScale = 0;
            Shooting_2.bPause = true;
            if (++iIntervalCount > 380)
            {
                iIntervalCount = 0;
                IntervalType = INTERVAL_TYPE.UN_INTERVAL;
            }
        }

        public void OnClearInterval() // インターバル実行中
        {
            IntervalBack.SetActive(true);
            IntervalClear.SetActive(true);
            IntervalStage1.SetActive(false);
            Time.timeScale = 0;
            Shooting_2.bPause = true;
            if (++iIntervalCount > 380)
            {
                iNowStage++;
                SpawnPoint_Behind.SpawnEnemyCount =
                iIntervalCount = 0;
                BoxScript.ugoku =
                enemys.SpawnPoint_Behind.EnemyGenerationFlg = true;
                IntervalType = INTERVAL_TYPE.UN_INTERVAL;
            }
        }

        public void OnUnInterval() // インターバル未実行
        {
            IntervalBack.SetActive(false);
            IntervalStage1.SetActive(false);
            IntervalClear.SetActive(false);
            Time.timeScale = 1;
            Shooting_2.bPause = false;
        }
    }
}