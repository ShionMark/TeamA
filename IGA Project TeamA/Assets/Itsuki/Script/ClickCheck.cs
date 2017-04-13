using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ChangeScene_Manager;

public class ClickCheck : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0)) 
        {
            ChangeScene_Manager.SceneScript.ChangeScene(ChangeScene_Manager.SCENE_NAME.SCENE_TEST);
        }
	}
}
