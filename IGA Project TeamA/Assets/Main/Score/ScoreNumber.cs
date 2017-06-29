using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace score
{
    public class ScoreNumber : MonoBehaviour
    {

        public static int numbers01MAX = 10;
        public static int numbers02MAX = 10;
        public static int numbers03MAX = 10;
        public static GameObject[] ScoreNumber01 = new GameObject[numbers01MAX];
        public static GameObject[] ScoreNumber02 = new GameObject[numbers02MAX];
        public static GameObject[] ScoreNumber03 = new GameObject[numbers03MAX];
        public static bool ScorePlusFlg = false;
        public static int score = 0;
        public static int Num01 = 0;
        public static int Num02 = 0;
        public static int Num03 = 0;


        // Use this for initialization
        void Start()
        {
            ScoreNumber01[Num01].SetActive(true);
            ScoreNumber02[Num02].SetActive(true);
            ScoreNumber03[Num03].SetActive(true);
        }

        // Update is called once per frame
        void Update()
        {
            if (ScorePlusFlg)
            {
                score++;
                ScoreNumber01[Num01].SetActive(false);
                ScoreNumber02[Num02].SetActive(false);
                ScoreNumber03[Num03].SetActive(false);

                Num01 = score % 10;
                Num02 = score / 10 % 10 ;
                Num03 = score / 100 % 10;

                ScoreNumber01[Num01].SetActive(true);
                ScoreNumber02[Num02].SetActive(true);
                ScoreNumber03[Num03].SetActive(true);

                ScorePlusFlg = false;
            }
        }
    }
}
