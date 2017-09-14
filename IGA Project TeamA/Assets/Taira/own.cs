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
        switch(coll.gameObject.tag)
        {
<<<<<<< HEAD
            case ("EnemyBullet"):

                break;

            case ("MasterSpark"):

                break;
        //if (coll.gameObject.CompareTag("EnemyBullet") || coll.gameObject.CompareTag("MasterSpark"))
        //{
            

=======
            Asuka.HPBar.DAMAGE();
>>>>>>> master
        }
    }
}
