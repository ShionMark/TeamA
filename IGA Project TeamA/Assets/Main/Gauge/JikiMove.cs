using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using StageMgr;

namespace JikiUI
{
    public class JikiMove : MonoBehaviour
    {
        public static Vector3 JikiPosition;

        void Start()
        {
            JikiPosition = this.gameObject.transform.localPosition;
        }
        void Update()
        {

           this.gameObject.transform.localPosition =  JikiPosition;

            //if (Input.GetKeyDown(KeyCode.Alpha3)) this.gameObject.transform.position += new Vector3(5.0f, 0.0f, 0.0f); //ふえりゅ（3キー)
            //if (Input.GetKeyDown(KeyCode.Alpha4)) this.gameObject.transform.position -= new Vector3(5.0f, 0.0f, 0.0f); //ふえりゅ（3キー)

            if (JikiPosition.x < 25) SceneManager.LoadScene("GameOverScene");

            if (StageManager.aikonMoveFlg == false)//通常
            {
                if (this.gameObject.transform.position.x <= 260) JikiPosition -= new Vector3(0.05f, 0.0f, 0.0f);
            }
            else//敵死亡
            {
                if (this.gameObject.transform.position.x <= 260) JikiPosition += new Vector3(0.1f, 0.0f, 0.0f);
            }
        }
    }
}