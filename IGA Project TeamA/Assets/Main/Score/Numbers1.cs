using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using score;

public class Numbers1 : MonoBehaviour {

    public int N01 = 0;
	// Use this for initialization
	void Start () {
        score.ScoreNumber.ScoreNumber01[N01] = this.gameObject;
        score.ScoreNumber.ScoreNumber01[N01].SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
