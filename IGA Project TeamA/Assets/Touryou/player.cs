using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 2f;
    public float width = 6f;
    public float heignt = 6f;
    private Vector3 position;

    // スクリーン座標をワールド座標に変換した位置座標
    private Vector3 screenToWorldPointPosition;

    // Update is called once per frame
    void OnMouseDrag()
    {
        float x = Mathf.Cos(Time.time * speed) * width;
        float y = Mathf.Sin(Time.time * speed) * heignt;
        float z = 0f;
        // transform.position = new Vector3(x, y, z);

        transform.Rotate(new Vector3(0, 0, 3));
        // Vector3でマウス位置座標を取得する
        position = Input.mousePosition;
        // Z軸修正
        position.z = 15f;
        // マウス位置座標をスクリーン座標からワールド座標に変換する
        screenToWorldPointPosition = Camera.main.ScreenToWorldPoint(position);
        // ワールド座標に変換されたマウス座標を代入
        gameObject.transform.position = screenToWorldPointPosition;
    }
}