using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{

    //public enum ITEM_TYPE { RE_MACHINE_ITEM, POWER_UP_ITEM }

    // Use this for initialization
    void Start()
    {
        this.GetComponent<Rigidbody>().AddForce(Random.Range(-200, 200), Random.Range(500, 1000), 0, ForceMode.Force);
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.transform.position.y <= -200) Destroy(this.gameObject);
    }

    void OnCollisionEnter(Collision collisions)
    {
        if (collisions.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }

}
