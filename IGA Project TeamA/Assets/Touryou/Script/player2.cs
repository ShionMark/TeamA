using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2 : MonoBehaviour
{
    public float speed = 2f;
    public float width = 6f;
    public float heignt = 6f;

    private Vector3 position;

    // Update is called once per frame
    void OnMouseDrag()
    {
        float x = Mathf.Cos(Time.time * speed) * width;
        float y = Mathf.Sin(Time.time * speed) * heignt;
        float z = 0f;
        transform.position = new Vector3(x, y, z);
    }
}