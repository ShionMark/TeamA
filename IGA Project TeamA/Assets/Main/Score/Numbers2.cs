using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using score;

public class Numbers2 : MonoBehaviour {

    public int N02 = 0;
	// Use this for initialization
	void Start () {
        score.ScoreNumber.ScoreNumber02[N02] = this.gameObject;
        score.ScoreNumber.ScoreNumber02[N02].SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
