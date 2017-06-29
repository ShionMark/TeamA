using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using highscore;

public class Numbers5 : MonoBehaviour {

    public int N05 = 0;

	// Use this for initialization
	void Start () {
		highscore.HighScoreNumber.HighScoreNumber02[N05] = this.gameObject;
        highscore.HighScoreNumber.HighScoreNumber02[N05].SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
