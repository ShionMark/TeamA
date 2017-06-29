using UnityEngine;
using System.Collections.Generic;
using System.Collections;



namespace StageMove{
    public class BoxScript : MonoBehaviour
    {

        const float modoru = -113;
        const float mikire = 643;
        const float mikire2 = -113;
        const float modoru2 = 643;
        private Vector3 m_pos;
        public static bool ugoku = true;
        public int w = 0;
       
      

        // Use this for initialization
        void Start()
        {
            m_pos = transform.localPosition;  // 形状位置を保持
        }

        // Update is called once per frame
        void Update()
        {
           
            transform.localPosition = m_pos;  // 形状位置を更新
            if (ugoku)
            {
                m_pos.z += 1f;    //動くやつ

                if (m_pos.z >= mikire) m_pos.z = modoru;  //僕には、まだ帰る場所があったんだ
                w = 0;
            }
            else
            {
                  m_pos.z -= 1f;    //動くやつ(逆)

                    if (m_pos.z < mikire2) m_pos.z = modoru2;  //僕には、まだ帰る場所があったんだ()
                w+=1;
                if (w >= 160)
                {
                    w = 0;
                   ugoku = true;
                  enemys.SpawnPoint_Behind.EnemyGenerationFlg = true;
                    
                }
            }
        }
    }
}