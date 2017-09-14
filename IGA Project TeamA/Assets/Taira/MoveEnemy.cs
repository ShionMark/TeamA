using UnityEngine;
using System.Collections;

namespace Move
{
    public class MoveEnemy : MonoBehaviour
    {
        public static bool patternFlg = false;
        public static int RollSpeed = 1;
        public static int pattern = 5;      //動きのパターン
        public bool m_xPlus = true;  // x 軸プラス方向に移動中か？
        public bool m_yPlus = true;  // y 軸プラス方向に移動中か？
        public float m_progress = 0f;      //  進捗 [0, 1)メビウス
        public float c_progress = 0f;      //  進捗 [0, 1)十字
        public int m_ix = 0;               //  メビウスの輪インデックス
        public int c_ix = 0;               //  十字インデックス
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
           if (patternFlg == true)
            {
                pattern = Random.Range(0, 5);
                patternFlg = false;
            }
         //  transform.Rotate(new Vector3(0, 0, RollSpeed));
            switch (pattern)
            {
                case 0://円移動
                    var x = 5f * Mathf.Sin(Time.time * 3.0f);
                    var y = 5f * Mathf.Cos(Time.time * 2.0f);
                    transform.position = new Vector3(x, y, 0f);
                    break;

                case 1://メビウスの輪
                    m_progress += 2f * Time.deltaTime;
                    if (m_progress >= 1.0f)
                    {
                        m_progress = 0f;
                        if (++m_ix >= m_data.Length - 1.0f)
                            m_ix = 0;
                    }
                    transform.position = Vector3.Lerp(m_data[m_ix], m_data[m_ix + 1], m_progress);
                    break;

                case 2://十字移動
                    c_progress += 3f * Time.deltaTime;
                    if (c_progress >= 1.0f)
                    {
                        c_progress = 0f;
                        if (++c_ix >= c_data.Length - 1)
                            c_ix = 0;
                    }
                    transform.position = Vector3.Lerp(c_data[c_ix], c_data[c_ix + 1], c_progress);
                    break;

                case 3://横往復
                    if (m_xPlus)
                    {
                        transform.position += new Vector3(10.0f * Time.deltaTime, 0f, 0f);
                        if (transform.position.x >= 5) m_xPlus = false;
                    }
                    else
                    {
                        transform.position -= new Vector3(10.0f * Time.deltaTime, 0f, 0f);
                        if (transform.position.x <= -5) m_xPlus = true;
                    }
                    break;

                case 4://縦往復
                 //   transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time * 5f, 5), transform.position.z);

                      if (m_yPlus)
                    {
                        transform.position += new Vector3(0f, 10f * Time.deltaTime, 0f);
                        if (transform.position.y >= 8) m_yPlus = false;
                    }
                    else
                    {
                        transform.position -= new Vector3(0f, 10f * Time.deltaTime, 0f);
                        if (transform.position.y <= -5) m_yPlus = true;
                    }
                    break;

                default://回転行動
                    transform.position = new Vector3(0f, 0f, 0f);
                    break;
            }

            /*  if (Input.GetMouseButtonDown(0)) {
                  pattern++;
                  if (pattern >5) pattern = 1;
                  transform.position = new Vector3(0, 0, 0);
             }*/
            /*  if (Input.GetMouseButtonDown(1)){
                  RollSpeed *= -1;
              }*/

        }

    }
}