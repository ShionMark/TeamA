using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


namespace Asuka
{
    public class FuelBar : MonoBehaviour
    {

        const float GBARANIME = 0.05f;//回復の上昇アニメ
        const float RBARANIME = 0.03f;//ダメージの赤ゲージアニメ
        const float DAMAGE1 = 0.15f;//ダメージ
        const float RECOBAR1 = 0.30f;//回復量

        public Image FuelBarGreen;
        public Image FuelBarRed;
        float /*Gbar, Rbar,*/ Recobar;
        bool damage, recove;

        // Use this for initialization
        void Start()
        {
            damage = false;
            recove = false;
            //Gbar = FuelBarGreen.transform.localScale.y;
        }

        // Update is called once per frame
        void Update()
        {
            if (FuelBarGreen.fillAmount >= 0 && recove == false) FuelBarGreen.fillAmount -= 1.0f * Time.deltaTime / 40; //徐々に減らす

            if (FuelBarGreen.fillAmount <= 0.0 && FuelBarRed.fillAmount <= 0.0) SceneManager.LoadScene("GameOverScene");

            if (damage == true)
            {
                if (FuelBarRed.fillAmount >= FuelBarGreen.fillAmount)
                {
                    FuelBarRed.fillAmount -= RBARANIME;
                }
                else
                {
                    FuelBarRed.fillAmount = FuelBarGreen.fillAmount;
                    damage = false;
                }
            }

            if (recove == true)
            {
                if (Recobar >= FuelBarGreen.fillAmount && FuelBarGreen.fillAmount < 1)
                {
                    FuelBarGreen.fillAmount = (FuelBarGreen.fillAmount <= 0.95) ? FuelBarGreen.fillAmount + GBARANIME : 1;
                }
                else
                {
                    recove = false;
                }
            }

            if (recove == false && damage == false) FuelBarRed.fillAmount = FuelBarGreen.fillAmount;

            //FuelBarGreen.transform.localScale = new Vector3(transform.localScale.x, FuelBarGreen.fillAmount, transform.localScale.z);
            //FuelBarRed.transform.localScale = new Vector3(transform.localScale.x, FuelBarRed.fillAmount, transform.localScale.z);

            if (Input.GetKeyDown(KeyCode.Alpha1) && FuelBarGreen.fillAmount > 0)//ダメージ(1キー)
            {
                FuelBarGreen.fillAmount = (FuelBarGreen.fillAmount >= DAMAGE1) ? FuelBarGreen.fillAmount -= DAMAGE1 : 0.0f;
                damage = true;
            }

            if (Input.GetKeyDown(KeyCode.Alpha2) && FuelBarGreen.fillAmount > 0 && FuelBarGreen.fillAmount <= 1)//回復(2キー)
            {
                Recobar = (FuelBarGreen.fillAmount <= 1 - RECOBAR1) ? FuelBarGreen.fillAmount + RECOBAR1 : 1.0f;
                recove = true;
            }


        }
    }
}