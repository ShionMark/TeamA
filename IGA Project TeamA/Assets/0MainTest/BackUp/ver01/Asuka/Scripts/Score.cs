using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Itsuki_ver1
{
    public class Score : MonoBehaviour
    {

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
            if (Input.GetMouseButtonDown(0)) score++;//マウスクリック時にポイント加算
            if (Input.GetKeyDown(KeyCode.Alpha0)) highScore = 0;//ハイスコアの初期化(0キー)


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