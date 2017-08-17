using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PM;
using Shooting;

namespace ItemMgr
{
    public class ItemManager : MonoBehaviour
    {
        private static int iMyPower, iMyHeart;//弾の威力 : 残基
        public static int iRandItem;
        public GameObject[] PrefabItems;

        void Start()
        {
            iMyPower =
            iMyHeart = 0;
        }

        // Update is called once per frame
        void Update()
        {
            if (score.ScoreNumber.ScorePlusFlg)
            {
                iRandItem = Random.Range(0, 1);
                if (iRandItem <= 1)
                {
                    GameObject.Instantiate(PrefabItems[iRandItem], transform.position, Quaternion.identity);
                }
                else
                {
                    Debug.Log("NO ITEMS");
                }
            }
        }

        public static void PickUpItems()
        {
            switch (iRandItem)
            {
                case 0:
                    if (iMyPower <= 6)
                    {
                        iMyPower++;
                        Shooting_2.iNowBulletLevel = iMyPower / 2;
                    }
                    break;
                case 1:
                    iMyHeart++;
                    break;
            }

            Debug.Log("パワー" + iMyPower);
            Debug.Log("残基" + iMyHeart);
        }
    }
}