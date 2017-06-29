using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using highscore;

public class Numbers6 : MonoBehaviour {

    public int N06 = 0;

	// Use this for initialization
	void Start () {
		highscore.HighScoreNumber.HighScoreNumber03[N06] = this.gameObject;
        highscore.HighScoreNumber.HighScoreNumber03[N06].SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
