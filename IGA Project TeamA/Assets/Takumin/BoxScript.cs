using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class BoxScript : MonoBehaviour
{

    private Vector3 m_pos;

    // Use this for initialization
    void Start()
    {
        m_pos = transform.localPosition;  // 形状位置を保持
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = m_pos;  // 形状位置を更新
        m_pos.z -= 50f;

        if (m_pos.z <= -750)
        {
            m_pos.z = 2300;
        }
    }
}