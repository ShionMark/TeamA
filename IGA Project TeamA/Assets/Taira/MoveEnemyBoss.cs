using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace BossMove
{
    public class MoveEnemyBoss : MonoBehaviour
    {


        public float Boss01_RollSpeed = 0f;
        public float Boss02_RollSpeed = 0f;
        public float Boss03_RollSpeed = 0f;
        public float Boss04_RollSpeed = 0f;
        public float Boss05_RollSpeed = 0f;
        
        public static int Move_Pattern = 0;      //動きのパターン
        public bool m_xPlus = true;  // x 軸プラス方向に移動中か？
        public bool m_yPlus = true;  // y 軸プラス方向に移動中か？
        public bool Rote = false;   //trueで左回り。falseで右周りにBossが回転
        public float m_progress = 0f;      //  進捗 [0, 1)メビウス
        public float c_progress = 0f;      //  進捗 [0, 1)十字
        public int m_ix = 0;               //  メビウスの輪インデックス
        public int c_ix = 0;               //  十字インデックス
        private int Probability = 0;       //確率
        public float Boss01_WaitTime = 0f;
        public float Boss03_WaitTime = 0f;
        public float Boss04_WaitTime = 0f;
        public float Boss05_WaitTime = 0f;
        float Elapsedtime = 0f;
        public int Move_Direction = 1;

        Vector3[] m_data = {new Vector3( 0f,  7f,  0f),
                        new Vector3( 3.5f,  3.5f,  0f),
                        new Vector3(-3.5f,  3.5f,  0f),
                        new Vector3( 0f,  0f,  0f),
                        new Vector3( 3.5f, -3.5f,  0f),
                        new Vector3(-3.5f, -3.5f,  0f),
                        new Vector3( 0f,  7f,  0f)};//メビウスの輪移動座標

        Vector3[] c_data = {new Vector3( 0f,  0f,  0f),
                        new Vector3( 0f,  3.0f,  0f),
                        new Vector3( 0f,  0f,  0f),
                        new Vector3( 0f, -2.5f,  0f),
                        new Vector3( 0f,  0f,  0f),
                        new Vector3(-4.5f,  0f,  0f),
                        new Vector3( 0f,  0f,  0f),
                        new Vector3( 4.5f,  0f,  0f),
                        new Vector3( 0f,  0f,  0f)};//十字移動座標

        void Start()
        {
            transform.position = m_data[m_ix];
            transform.position = c_data[c_ix];
        }

        void Update()
        {

            switch (Move_Pattern)
            {
               
                case 1://boss01
                    transform.Rotate(new Vector3(0, 0, Boss01_RollSpeed));
                    if(Elapsedtime >= Boss01_WaitTime){
                        if (m_xPlus)
                        {
                            transform.position += new Vector3(10.0f * Time.deltaTime, 0f, 0f);
                            if (transform.position.x >= 4)
                            {
                                Elapsedtime = 0;
                                m_xPlus = false;
                            }
                        }
                        else
                        {
                            transform.position -= new Vector3(10.0f * Time.deltaTime, 0f, 0f);
                            if (transform.position.x <= -4)
                            {
                                Elapsedtime = 0;
                                m_xPlus = true;
                            }
                        }
                    }else{
                        Elapsedtime += Time.deltaTime;
                    }
                    break;


                case 2://boss02
                    transform.Rotate(new Vector3(0, 0, Boss02_RollSpeed));
                    transform.position = new Vector3(0f, 0f, 0f);
                    break;


                case 3://boss03
                    Elapsedtime += Time.deltaTime;
                    if (Elapsedtime <= Boss03_WaitTime)
                    {
                        transform.Rotate(new Vector3(0, 0, Boss03_RollSpeed));
                        transform.position = new Vector3(0f, 0f, 0f);
                    }
                    else 
                    {
                        if (Elapsedtime <= Boss03_WaitTime * 2)
                        {
                            transform.Rotate(new Vector3(0, 0, -Boss03_RollSpeed));
                            transform.position = new Vector3(0f, 0f, 0f);
                        }
                        else
                        {
                            Elapsedtime = 0;
                        }
                    }
                    break;


                case 4:
                    Elapsedtime += Time.deltaTime;
                    if (Elapsedtime >= Boss04_WaitTime)
                    {
                        Probability = Random.Range(0, 10);
                        Elapsedtime = 0;
                    }
                    if (Probability >= 5)
                    {
                        transform.Rotate(new Vector3(0, 0, Boss04_RollSpeed));
                    }

                    switch (Move_Direction)
                    {
                        case 1:

                            this.transform.position += new Vector3(0f, 5.0f * Time.deltaTime, 0f);

                            if (this.transform.position.y >= 5) Move_Direction = 2;
                            break;

                        case 2:
                            this.transform.position += new Vector3(5.0f * Time.deltaTime, 0f, 0f);

                            if (this.transform.position.x >= 5) Move_Direction = 3;
                            break;

                        case 3:
                            this.transform.position -= new Vector3(0f, 5.0f * Time.deltaTime, 0f);

                            if (this.transform.position.y <= -5) Move_Direction = 4;
                            break;

                        case 4:
                             this.transform.position -= new Vector3(5.0f * Time.deltaTime, 0f, 0f);

                            if (this.transform.position.x <= -5) Move_Direction = 1;
                            break;
                    }
                    break;

                case 5:
                    Elapsedtime += Time.deltaTime;
                    if (Elapsedtime >= Boss05_WaitTime)
                    {
                        Probability = Random.Range(0, 10);
                        Elapsedtime = 0;
                    }
                    if (Probability >= 3)
                    {
                        transform.Rotate(new Vector3(0, 0, Boss05_RollSpeed));
                    }

                    switch (Move_Direction)
                    {
                        case 1:

                            this.transform.position += new Vector3(0f, 5.0f * Time.deltaTime, 0f);

                            if (this.transform.position.y >= 5) Move_Direction = 2;
                            break;

                        case 2:
                            this.transform.position += new Vector3(5.0f * Time.deltaTime, 0f, 0f);

                            if (this.transform.position.x >= 5) Move_Direction = 3;
                            break;

                        case 3:
                            this.transform.position -= new Vector3(0f, 5.0f * Time.deltaTime, 0f);

                            if (this.transform.position.y <= -5) Move_Direction = 4;
                            break;

                        case 4:
                            this.transform.position -= new Vector3(5.0f * Time.deltaTime, 0f, 0f);

                            if (this.transform.position.x <= -5) Move_Direction = 1;
                            break;
                    }
                    break;

            }

        }

    }

}