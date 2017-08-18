using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class own : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //オブジェクトが衝突したとき
    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "EnemyBullet")
        {
            PlayerHp.playerHp -= 1.0f;
            Destroy(coll.gameObject);
        }
    }
}
