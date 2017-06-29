using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD
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
=======
//public class player : MonoBehaviour
////{
////    public float speed = 2f;
////    public float width = 6f;
////    public float heignt = 6f;
////    private Vector3 position;

////    // スクリーン座標をワールド座標に変換した位置座標
////    private Vector3 screenToWorldPointPosition;

////    // Update is called once per frame
////    void OnMouseDrag()
////    {
////        float x = Mathf.Cos(Time.time * speed) * width;
////        float y = Mathf.Sin(Time.time * speed) * heignt;
////        float z = 0f;
////        // transform.position = new Vector3(x, y, z);

////        transform.Rotate(new Vector3(0, 0, 3));
////        // Vector3でマウス位置座標を取得する
////        position = Input.mousePosition;
////        // Z軸修正
////        position.z = 15f;
////        // マウス位置座標をスクリーン座標からワールド座標に変換する
////        screenToWorldPointPosition = Camera.main.ScreenToWorldPoint(position);
////        // ワールド座標に変換されたマウス座標を代入
////        gameObject.transform.position = screenToWorldPointPosition;
////    }
//}
>>>>>>> origin/master
