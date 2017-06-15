using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Asuka
{
    public class Score : MonoBehaviour
    {

        public static bool ScoreFlg = false; 
        Text ScoreText;
        Text HScoreText;

        public static int score;
        private static int highScore;

        private string key = "HIGH SCORE";

        // Use this for initialization
        void Start()
        {
            score = 0;
            ScoreText = GetComponent<Text>();
            HScoreText = GetComponent<Text>();

            highScore = PlayerPrefs.GetInt(key, 0);//ハイスコアの読み込み
            HScoreText.text = "HighScore: " + highScore.ToString();//ハイスコアの表示
        }

        // Update is called once per frame
        void Update()
        {
            if (ScoreFlg == true)
            {
                score++;
                ScoreFlg = false;
            }
            //if (Input.GetKeyDown(KeyCode.Alpha0)) highScore = 0;//ハイスコアの初期化(0キー)
            if (FuelBar.Gbar <= 0)
            {
                score = 0;
            }

            ScoreText.text = "HighScore : " + highScore.ToString() + "\n        Score : " + score; //表示

            if (score > highScore)
            {
                //ハイスコア更新
                highScore = score;
                //ハイスコアを保存
                PlayerPrefs.SetInt(key, highScore);
            }
        }
    }
}