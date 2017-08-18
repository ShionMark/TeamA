using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gage1
{
    public class HPcontroller : MonoBehaviour
    {

        Slider _slider;



        // Use this for initialization
        void Start()
        {

            _slider = GameObject.Find("Slider").GetComponent<Slider>();

        }

        public static float _hp = 50;
        public float n = 0;

        // Update is called once per frame
        void Update()
        {

            _hp -= 0.05f;

            
            //if (Input.GetKeyDown(KeyCode.Alpha2) && _hp < 100)
            //{
            //     n += 10;
            //    _hp += n;
            //}
                  
            _slider.value = _hp;
        }
    }
}