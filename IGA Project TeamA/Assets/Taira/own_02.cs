using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class own_02: MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //オブジェクトが衝突したとき
    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.CompareTag("EnemyBullet") || coll.gameObject.CompareTag("MasterSpark"))
        {
            Asuka.HPBar.DAMAGE();
        }
    }
}
