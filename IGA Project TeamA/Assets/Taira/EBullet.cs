﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EBullet : MonoBehaviour {

    public static GameObject Bullets;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!GetComponent<Renderer>().isVisible){
            Destroy(this.gameObject);
        }
        else if (this.gameObject.transform.position.x > 40 || this.gameObject.transform.position.x < -40)
        {
            Destroy(this.gameObject);
        }
        else if (this.gameObject.transform.position.y > 40 || this.gameObject.transform.position.y < -40)
        {
            Destroy(this.gameObject);
        }
	}

    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.CompareTag("Bullet"))
        {
            Destroy(coll.gameObject);
        }
    }

}
