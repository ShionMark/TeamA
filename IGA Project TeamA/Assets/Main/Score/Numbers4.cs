using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using highscore;

public class Numbers4 : MonoBehaviour {

    public int N04 = 0;

	// Use this for initialization
	void Start () {
        highscore.HighScoreNumber.HighScoreNumber01[N04] = this.gameObject;
        highscore.HighScoreNumber.HighScoreNumber01[N04].SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
