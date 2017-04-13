using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //オブジェクトが衝突したとき
    void OnCollisionEnter(Collision collisions)
    {
        Destroy(this.gameObject);
    }
}
