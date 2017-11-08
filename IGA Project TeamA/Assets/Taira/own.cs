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
    void OnTriggerEnter(Collider coll)
    {
       
       // if (coll.gameObject.CompareTag("EnemyBullet") || coll.gameObject.CompareTag("MasterSpark"))
        switch(coll.gameObject.tag)
        {
            case ("EnemyBullet"):
                Asuka.HPBar.HitPattern = 0;
                Asuka.HPBar.DAMAGE();
                break;
            case ("MasterSpark"):
                
                Asuka.HPBar.HitPattern = 1;
                Asuka.HPBar.DAMAGE();
                break;
            default:
                break;
        }
    }
}
