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

        public static GameObject e2_Weak01;
        public static GameObject e2_Weak02;
        public static GameObject e3_Weak01;
        public static GameObject e3_Weak02;

        
        public static bool EnemyGenerationFlg = true;

        void Start()
        {
          //  enemy = new GameObject[enemyMAX];

           
        }

        void Update()
        {
            if (EnemyGenerationFlg == true)
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