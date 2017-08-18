using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jikiMove1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x < 10)
        {
            transform.position += new Vector3(3f, 0.0f, 0.0f);
        }
    }

    internal void PlayerMove()
    {
        if (transform.position.x < 10)
        {
            transform.position += new Vector3(3f, 0.0f, 0.0f);
        }
        //throw new NotImplementedException();
    }
}
