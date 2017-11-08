using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PM;
using Shooting;

namespace ItemMgr
{
    public class ItemManager : MonoBehaviour
    {
        private static int iMyPower;//弾の威力
        public static int iRandItem;
        public static bool bSpawnItemFlg;
        public GameObject[] PrefabItems;
        public int iProb;
        void Start()
        {
            bSpawnItemFlg = false;
            iMyPower = 0;
        }

        // Update is called once per frame
        void Update()
        {
            if (bSpawnItemFlg)
            {
                bSpawnItemFlg = false;
                iRandItem = Random.Range(0, iProb);
                if (iRandItem <= 1) GameObject.Instantiate(PrefabItems[iRandItem], transform.position, Quaternion.identity);
            }
        }

        public static void PickUpItems()
        {
            switch (iRandItem)
            {
                case 0:
                    if (iMyPower <= 6)
                    {
                        Shooting_2.iNowBulletLevel = ++iMyPower / 2;
                    }
                    break;
                case 1:
                    Asuka.HPBar.RECO();
                    break;
            }
        }
    }
}