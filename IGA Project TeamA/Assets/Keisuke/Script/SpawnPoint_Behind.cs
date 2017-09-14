using UnityEngine;
using System.Collections;
using Move;
using StageMgr;
using JikiUI;

namespace enemys
{
    public class SpawnPoint_Behind : MonoBehaviour
    {
        private static int enemyMAX = 8;
        public static GameObject[] enemy = new GameObject[enemyMAX];
        public static GameObject[,] weak = new GameObject[enemyMAX, 2];
        public static int i;
        public static int SpawnEnemyCount;

        public AudioClip[] sound;

        public static bool EnemyGenerationFlg;

        void Start()
        {
            //  enemy = new GameObject[enemyMAX];
            EnemyGenerationFlg = true;
            //SpawnEnemyCount = 0;
        }

        void Update()
        {
            if (EnemyGenerationFlg)
            {
                if (JikiMove.JikiPosition.x <= 260)
                {
                    i = Random.Range(0, enemyMAX - 5);
                }
                else
                {
                    i = enemyMAX - 5 + StageManager.iNowStage;
                }

                enemy[i].SetActive(true);

                for (int r = 0; r < 2; r++)
                {
                    if (weak[i, r] != null)
                    {
                        weak[i, r].SetActive(true);
                    }
                }
                Move.MoveEnemy.patternFlg = true;
                EnemyGenerationFlg = false;
            }
        }
    }
}