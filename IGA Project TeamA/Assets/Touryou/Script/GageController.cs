using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gage2
{
    public class GageController : MonoBehaviour
    {


        Slider GagePlayer;
        public  Slider _slider;
        public static float _hp = 50;
        //public float n = 0;

        // Use this for initialization
        void Start()
        {
            GagePlayer = GameObject.Find("Gauge").GetComponent<Slider>();
        }

        // Update is called once per frame
        void Update()
        {
            _hp -= 0.05f;
            _slider.value = _hp;
        }
    }
}