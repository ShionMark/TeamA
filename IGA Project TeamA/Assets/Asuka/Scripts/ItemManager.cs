using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PM;

public class ItemManager : MonoBehaviour
{

    private int iRandItem;
    public GameObject[] PrefabItems;

    // Update is called once per frame
    void Update()
    {

        if (score.ScoreNumber.ScorePlusFlg)
        {
            iRandItem = Random.Range(0, 9);
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

}