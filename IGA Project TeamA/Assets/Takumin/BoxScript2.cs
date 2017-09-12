using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StageMove;

namespace StageMove2
{
    public class BoxScript2 : MonoBehaviour
    {

        public static Vector3 R2Pos;

        // Use this for initialization
        void Start()
        {
            R2Pos = this.transform.localPosition;
        }

        // Update is called once per frame
        void Update()
        {
            this.transform.localPosition = R2Pos;  // 形状位置を更新

            if (StageMove.BoxScript.ugoku)
            {
                if (R2Pos.z > 631)
                {
                    R2Pos.z = BoxScript.R1Pos.z - 630;
                }
                R2Pos.z += 1;
            }
            else
            {
                if (R2Pos.z < -630)
                {
                    R2Pos.z = BoxScript.R1Pos.z + 630;
                }
                
                R2Pos.z -= 1;
            }
        }
    }
}