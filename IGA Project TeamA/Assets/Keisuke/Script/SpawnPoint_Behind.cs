using UnityEngine;
using System.Collections;
using Move;

namespace enemys
{
    public class SpawnPoint_Behind : MonoBehaviour
    {
        private static int enemyMAX = 3;
        public static GameObject[] enemy = new GameObject[enemyMAX];
        public static GameObject[,] weak = new GameObject[enemyMAX,2];
        public static int i;

        public AudioClip[] sound;
        
        public static bool EnemyGenerationFlg;

        void Start()
        {
          //  enemy = new GameObject[enemyMAX];
            EnemyGenerationFlg = true;
           
        }

        void Update()
        {
            if (EnemyGenerationFlg)
            {

                i = Random.Range(0, enemyMAX);
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