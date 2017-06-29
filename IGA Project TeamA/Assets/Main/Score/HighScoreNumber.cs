using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using score;

namespace highscore
{
    public class HighScoreNumber : MonoBehaviour
    {

        public static int numbers04MAX = 10;
        public static int numbers05MAX = 10;
        public static int numbers06MAX = 10;
        public static GameObject[] HighScoreNumber01 = new GameObject[numbers04MAX];
        public static GameObject[] HighScoreNumber02 = new GameObject[numbers05MAX];
        public static GameObject[] HighScoreNumber03 = new GameObject[numbers06MAX];
        public int hscore = 0;
        public int HNum01 = 0;
        public int HNum02 = 0;
        public int HNum03 = 0;
        private string HIGHSCORE = "HIGH SCORE";

        // Use this for initialization
        void Start()
        {
            //PlayerPrefs.DeleteAll();

            hscore = PlayerPrefs.GetInt(HIGHSCORE, 0);//ハイスコアの読み込み
            HNum01 = hscore % 10;
            HNum02 = hscore / 10 % 10;
            HNum03 = hscore / 100 % 10;
            HighScoreNumber01[HNum01].SetActive(true);
            HighScoreNumber02[HNum02].SetActive(true);
            HighScoreNumber03[HNum03].SetActive(true);
        }

        // Update is called once per frame
        void Update()
        {
            if (score.ScoreNumber.score > hscore) 
            {
                hscore = score.ScoreNumber.score;

                HighScoreNumber01[HNum01].SetActive(false);
                HighScoreNumber02[HNum02].SetActive(false);
                HighScoreNumber03[HNum03].SetActive(false);
                HNum01 = score.ScoreNumber.Num01;
                HNum02 = score.ScoreNumber.Num02;
                HNum03 = score.ScoreNumber.Num03;

                HighScoreNumber01[HNum01].SetActive(true);
                HighScoreNumber02[HNum02].SetActive(true);
                HighScoreNumber03[HNum03].SetActive(true);
                PlayerPrefs.SetInt(HIGHSCORE, hscore);
            }
        }
    }
}