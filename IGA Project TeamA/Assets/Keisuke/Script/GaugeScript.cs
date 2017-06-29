using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GaugeScript : MonoBehaviour
{
    float temp;
    void Update()
    {
        temp = transform.localScale.y;
        if (temp > -1)
        {
            temp -= 1 * Time.deltaTime / 20;
       
            transform.localScale = new Vector3(
                transform.localScale.x, 
                temp, 
                transform.localScale.z);
        }
    }
   

}
