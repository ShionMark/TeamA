using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour {

    GameObject GageBoss;


    // Use this for initialization
    void Start()
    {
        GageBoss = GameObject.Find("Boss01").GetComponent<GameObject>();
    }
	// Update is called once per frame
    void Update()
    {
        if (transform.position.x > -13.5)
        {
            transform.position -= new Vector3(0.015f, 0.0f, 0.0f);
        }
        //if (Input.GetKeyDown(KeyCode.Alpha1) && transform.position.x > -12)
        //{
        //    transform.position -= new Vector3(2.4f, 0.0f, 0.0f);
        //}

        //if (Input.GetKeyDown(KeyCode.Alpha2) && transform.position.x < 100)
        //{
        //    transform.position += new Vector3(1.4f, 0.0f, 0.0f);
        //}


    }
}
