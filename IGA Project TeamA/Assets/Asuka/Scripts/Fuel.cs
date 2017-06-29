using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fuel : MonoBehaviour {


    float fillProp = 0.75f;
 


	// Use this for initialization
	void Start () {
        Image GreenGage = transform.Find("GreenGage").GetComponent<Image>();
        GreenGage.fillAmount *= fillProp;
	}
	
	// Update is called once per frame
	void Update () {
        
	}
}
