using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StageMgr;

public class jikiaikonMove : MonoBehaviour
{

    public GameObject jiki;

    public jikiMove1 jikiMove1;

    // Use this for initialization
    void Start()
    {
        jikiMove1 = jiki.GetComponent<jikiMove1>();
    }

    // Update is called once per frame
    void Update()
    {
        if (StageManager.aikonMoveFlg == false)
        {
            if (transform.position.x < 10)
            {
                transform.position += new Vector3(3f, 0.0f, 0.0f);

            }
        }

    }
}



