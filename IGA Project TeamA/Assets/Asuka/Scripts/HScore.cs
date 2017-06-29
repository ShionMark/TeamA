using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Asuka;

namespace Asuka
{
    public class HScore : MonoBehaviour
    {

        Text HScoreText;

        private static int highScore;

        private string key = "HIGH SCORE";

        // Use this for initialization
        void Start()
        {
            HScoreText = GetComponent<Text>();

            highScore = PlayerPrefs.GetInt(key, 0);//ハイスコアの読み込み
            HScoreText.text = highScore.ToString();//ハイスコアの表示
        }

        // Update is called once per frame
        void Update()
        {
            HScoreText.text = highScore.ToString(); //表示

            if (Asuka.Score.score > highScore)
            {
                //ハイスコア更新
                highScore = Asuka.Score.score;
                //ハイスコアを保存
                PlayerPrefs.SetInt(key, highScore);
            }
        }
    }
}