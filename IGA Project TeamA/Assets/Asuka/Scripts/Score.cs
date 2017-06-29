using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Asuka;

namespace Asuka
{
    public class Score : MonoBehaviour
    {

        public static bool ScoreFlg = false; 
        Text ScoreText;

        public static int score;

        // Use this for initialization
        void Start()
        {
            score = 0;
            ScoreText = GetComponent<Text>();
        }

        // Update is called once per frame
        void Update()
        {
            if (ScoreFlg)
            {
                //SoundSyastem.SoundOn = 0;
                score++;
                ScoreFlg = false;
            }
            //if (Input.GetKeyDown(KeyCode.Alpha0)) highScore = 0;//ハイスコアの初期化(0キー)


            ScoreText.text = score.ToString(); //表示
        }
    }
}