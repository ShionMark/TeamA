using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JikiMove : MonoBehaviour {

    GameObject jiki;

	// Use this for initialization
	void Start () {
        jiki = GameObject.Find("jiki").GetComponent<GameObject>();
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x > -12)
        {
            transform.position -= new Vector3(0.005f, 0.0f, 0.0f);
        }
       
	}
}
