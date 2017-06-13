using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private Vector3 position;

    private bool MoveFlag;
    private Vector2 BaseMousePosition;

    //public Transform playermain;
    //public bool down = false;
    //public float limit = 10.0f;

    //private float _inertia = 0.0f;
    //private float _prevX;
    //private float _prevY;
    //private Vector2 _delta = new Vector2(0.0f, 0.0f);

    //Camera mainCamera;

    //void Awake()
    //{
    //    if (playermain == null)
    //    {
    //        playermain = transform;
    //    }

    //}

    void Start()
    {
        MoveFlag = false;
        BaseMousePosition = new Vector2(0, 0);
    }

    // スクリーン座標をワールド座標に変換した位置座標
    private Vector3 screenToWorldPointPosition;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            MoveFlag = true;
            BaseMousePosition = Input.mousePosition;
           /* //_delta.x = 0.0f;
            //_delta.y = 0.0f;
            //_prevX = Input.mousePosition.x;
            //_prevY = Input.mousePosition.y;
            //down = true;*/

        }
        if (Input.GetMouseButtonUp(0))
        {
            MoveFlag = false;
            //down = false;
            //if(_delta.magnitude>8.0f)
            //{
            //    float v = Mathf.Clamp(_delta.sqrMagnitude, 0.0f, limit);
            //    _delta.Normalize();
            //    _delta *= v;
            //    _inertia = 1.0f;

            //}
        }

        //if(down)
        //{
        //    _delta.x = _prevX - Input.mousePosition.x;
        //    _delta.y = _prevY - Input.mousePosition.y;
        //    _prevX = Input.mousePosition.x;
        //    _prevY = Input.mousePosition.y;
        //    Vector3 euler = new Vector3(-_delta.y, -_delta.x, 0.0f);
        //    playermain.Rotate(euler, Space.World);

        //}
        //else if(_inertia>= 0.0f)
        //{
        //    _inertia *= 0.97f;

        //    if (_inertia> 0.05f)
        //    {
        //        Vector3 euler = new Vector3(-_delta.y * _inertia, _delta.x * _inertia, 0.0f);
        //        playermain.Rotate(euler, Space.World);
        //    }
        //}
        //else
        //{
        //    _inertia = 0.0f;
        //}

        if (MoveFlag == true)
        {
            if (BaseMousePosition.x < Input.mousePosition.x)
            {
                transform.Rotate(new Vector3(0, 0, 3));
            }
            else if (BaseMousePosition.x > Input.mousePosition.x)
            {
                transform.Rotate(new Vector3(0, 0, -3));
            }

        }
    }
}