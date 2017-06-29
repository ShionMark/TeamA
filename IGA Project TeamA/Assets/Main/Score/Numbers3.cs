using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using score;

public class Numbers3 : MonoBehaviour {
    public int N03 = 0;

	// Use this for initialization
	void Start () {
        score.ScoreNumber.ScoreNumber03[N03] = this.gameObject;
        score.ScoreNumber.ScoreNumber03[N03].SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
