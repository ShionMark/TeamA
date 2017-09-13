using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPcontroller : MonoBehaviour {

    Slider _slider;
   
  
    
	// Use this for initialization
	void Start () {

        _slider = GameObject.Find("Slider").GetComponent<Slider>();
        
	}

    float _hp = 50;
  
    // Update is called once per frame
    void Update () {

        _hp -= 0.05f;

        if (Input.GetKeyDown(KeyCode.Alpha1)&&_hp>0)
        {
            _hp -= 10;
        }

        if(Input.GetKeyDown(KeyCode.Alpha2)&&_hp<100)
        {
            _hp += 5;
        }



        if (_hp >= 100)
        {
            Debug.Log("GameClear");
        }
        else if (_hp < 0)
        {
            Debug.Log("GameOver");
        }

        _slider.value = _hp;
	}
}
