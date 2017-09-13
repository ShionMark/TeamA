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
            //Asuka.HPBar.FuelBarGreen.transform.localScale = (Asuka.HPBar.FuelBarGreen.transform.localScale.x >= Asuka.HPBar.DAMAGE1) ? 
             //   Asuka.HPBar.FuelBarGreen.transform.localScale -= new Vector3(Asuka.HPBar.DAMAGE1, 0.0f, 0.0f) : new Vector3(1.0f, 1.0f, 1.0f);
            Asuka.HPBar.bdamage = true;
        }
    }
}
