using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StageMgr;

namespace JikiUI
{
    public class JikiMove : MonoBehaviour
    {
        public static Vector3 JikiPosition;

        void Update()
        {

            if (Input.GetKeyDown(KeyCode.Alpha3)) this.gameObject.transform.position += new Vector3(5.0f, 0.0f, 0.0f); //ふえりゅ（3キー)

            JikiPosition = this.transform.localPosition;

            if (StageManager.aikonMoveFlg == false)//通常
            {
                if (this.gameObject.transform.position.x > -12)
                {
                    this.gameObject.transform.position -= new Vector3(0.1f, 0.0f, 0.0f);
                }
            }
            else//敵死亡
            {
                if (this.gameObject.transform.position.x > -12)
                {
                    this.gameObject.transform.position += new Vector3(1.0f, 0.0f, 0.0f);

                }
            }
        }
    }
}