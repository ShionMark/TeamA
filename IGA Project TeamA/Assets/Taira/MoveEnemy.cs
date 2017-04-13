using UnityEngine;
using System.Collections;

public class MoveEnemy : MonoBehaviour {

    public int RollSpeed = 20;
    public int pattern = 1;
    public bool m_xPlus = true;  // x 軸プラス方向に移動中か？
    public float m_progress = 0f;      //  進捗 [0, 1)メビウス
    public float c_progress = 0f;      //  進捗 [0, 1)十字
    public int m_ix = 0;               //  メビウスの輪インデックス
    public int c_ix = 0;               //  十字インデックス
    Vector3[] m_data = {new Vector3( 0f,  0f,  0f),
                        new Vector3( 1f,  1f,  0f),
                        new Vector3(-1f,  1f,  0f),
                        new Vector3( 0f,  0f,  0f),
                        new Vector3( 1f, -1f,  0f),
                        new Vector3(-1f, -1f,  0f),
                        new Vector3( 0f,  0f,  0f)};//メビウスの輪移動座標

    Vector3[] c_data = {new Vector3( 0f,  0f,  0f),
                        new Vector3( 0f,  1f,  0f),
                        new Vector3( 0f,  0f,  0f),
                        new Vector3( 0f, -1f,  0f),
                        new Vector3( 0f,  0f,  0f),
                        new Vector3(-1f,  0f,  0f),
                        new Vector3( 0f,  0f,  0f),
                        new Vector3( 1f,  0f,  0f),
                        new Vector3( 0f,  0f,  0f)};//十字移動座標

    void Start () {
        transform.position = m_data[m_ix];
        transform.position = c_data[c_ix];
    }
	
	void Update () {
        transform.Rotate(new Vector3(0, 0, RollSpeed));
        switch (pattern) {
            case 1://円移動
                var x = 1f * Mathf.Sin(Time.time*2.5f);
                var y = 1f * Mathf.Cos(Time.time*2.5f);
                transform.position = new Vector3(x, y, 0f);               
                break;
            case 2://メビウスの輪
                m_progress += 1f * Time.deltaTime;
                if (m_progress >= 1.0f)
                {
                    m_progress = 0f;
                    if (++m_ix >= m_data.Length - 1)
                        m_ix = 0;
                }
                transform.position = Vector3.Lerp(m_data[m_ix], m_data[m_ix + 1], m_progress);
                break;
            case 3://十字移動
                c_progress += 1f * Time.deltaTime;
                if (c_progress >= 1.0f)
                {
                    c_progress = 0f;
                    if (++c_ix >= c_data.Length - 1)
                        c_ix = 0;
                }
                transform.position = Vector3.Lerp(c_data[c_ix], c_data[c_ix + 1], c_progress);
                break;
            case 4://横往復
                if (m_xPlus){
                    transform.position += new Vector3(1f * Time.deltaTime, 0f, 0f);
                    if (transform.position.x >= 1) m_xPlus = false;
                }else{
                    transform.position -= new Vector3(1f * Time.deltaTime, 0f, 0f);
                    if (transform.position.x <= -1) m_xPlus = true;                       
                }
                break;
            case 5://縦往復
                transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time * 2f, 2), transform.position.z);
                break;
            default://回転行動
                transform.position = new Vector3(0f,0f,0f);
              break;
           }
        
        if (Input.GetMouseButtonDown(0)) {
            pattern++;
            if (pattern >5) pattern = 1;
            transform.position = new Vector3(0, 0, 0);
       }
        if (Input.GetMouseButtonDown(1)){
            RollSpeed *= -1;
        }

    }

}
