using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StageMgr;

public class jikiMove1 : MonoBehaviour {

	// Use this for initialization
	public void Start () {
        if (transform.position.x < 10 && StageManager.aikonMoveFlg == false)
        {
            transform.position += new Vector3(3f, 0.0f, 0.0f);
            
        }
	}
	
	// Update is called once per frame
    //public void Update()
    //{
             
    //    if (transform.position.x < 10)
    //    {
    //        transform.position += new Vector3(3f, 0.0f, 0.0f);
    //    }
    //    //throw new NotImplementedException();
    //}
}
