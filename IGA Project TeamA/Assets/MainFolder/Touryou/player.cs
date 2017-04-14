using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Itsuki
{
    public class player : MonoBehaviour
    {
        private Vector3 position;

        private bool MoveFlag;
        private Vector2 BaseMousePosition;

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
            }
            if (Input.GetMouseButtonUp(0))
            {
                MoveFlag = false;
            }

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

        // Update is called once per frame
        //void OnMouseDrag()
        //{
        //    float x = Mathf.Cos(Time.time * speed) * width;
        //    float y = Mathf.Sin(Time.time * speed) * heignt;
        //    float z = 0f;

        //    transform.Rotate(new Vector3(0, 0, 3));

        //    // Vector3でマウス位置座標を取得する
        //    position = Input.mousePosition;
        //    // Z軸修正
        //    position.z = 15f;
        //    // マウス位置座標をスクリーン座標からワールド座標に変換する
        //    screenToWorldPointPosition = Camera.main.ScreenToWorldPoint(position);
        //    // ワールド座標に変換されたマウス座標を代入
        //    gameObject.transform.position = screenToWorldPointPosition;
        //}
    }
}