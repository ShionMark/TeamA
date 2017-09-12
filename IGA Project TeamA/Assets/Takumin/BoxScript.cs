using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StageMove2;

namespace StageMove
{
    public class BoxScript : MonoBehaviour
    {
	 public static Vector3 R1Pos;
     public static bool ugoku;

        // Use this for initialization
        void Start()
        {
            R1Pos = this.transform.localPosition;
        }

        // Update is called once per frame
        void Update()
        {
                this.transform.localPosition = R1Pos;  // 形状位置を更新

                if (ugoku)
                {
                    if (R1Pos.z > 630)
                    {
                        R1Pos.z = BoxScript2.R2Pos.z - 630;
                    }
                    
                    R1Pos.z += 1;
                }
                else
                {
                    if (R1Pos.z < -630)
                    {
                        R1Pos.z = BoxScript2.R2Pos.z + 630;
                    }
                    
                    R1Pos.z -= 1;
                }
        }
    }
}