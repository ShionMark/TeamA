﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Taira;
public class Masupa_L : MonoBehaviour {

    private ParticleSystem MSP;
    private Collider Col;

	// Use this for initialization
	void Start () {
        MSP = GetComponent<ParticleSystem>();
        Col = GetComponent<Collider>();
        Taira.EnemyShooting.Masupa_L = this.gameObject;
       // this.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        Col.enabled = MSP.isEmitting;
	}


}
