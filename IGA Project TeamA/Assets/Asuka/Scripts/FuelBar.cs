using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace Itsuki
{
    public class FuelBar : MonoBehaviour
    {

        const float GBARANIME = 0.05f;//回復の上昇アニメ
        const float RBARANIME = 0.03f;//ダメージの赤ゲージアニメ
        const float DAMAGE1 = 0.15f;//ダメージ
        const float RECOBAR1 = 0.30f;//回復量

        public Image FuelBarGreen;
        public Image FuelBarRed;
        float Gbar, Rbar, Recobar;
        bool damage, recove;

        // Use this for initialization
        void Start()
        {
            damage = false;
            recove = false;
            Gbar = FuelBarGreen.transform.localScale.y;
        }

        // Update is called once per frame
        void Update()
        {
            if (Gbar >= 0 && recove == false) Gbar -= 1 * Time.deltaTime / 40; //徐々に減らす

            if (damage == true)
            {
                if (Rbar >= Gbar)
                {
                    Rbar -= RBARANIME;
                }
                else
                {
                    Rbar = Gbar;
                    damage = false;
                }
            }

            if (recove == true)
            {
                if (Recobar >= Gbar && Gbar < 1)
                {
                    Gbar = (Gbar <= 0.95) ? Gbar + GBARANIME : 1;
                }
                else
                {
                    recove = false;
                }
            }

            if (recove == false && damage == false) Rbar = Gbar;

            FuelBarGreen.transform.localScale = new Vector3(transform.localScale.x, Gbar, transform.localScale.z);
            FuelBarRed.transform.localScale = new Vector3(transform.localScale.x, Rbar, transform.localScale.z);

            if (Input.GetKeyDown(KeyCode.Alpha1) && Gbar > 0)//ダメージ(1キー)
            {
                Gbar = (Gbar >= DAMAGE1) ? Gbar -= DAMAGE1 : 0.0f;
                damage = true;
            }

            if (Input.GetKeyDown(KeyCode.Alpha2) && Gbar > 0 && Gbar <= 1)//回復(2キー)
            {
                Recobar = (Gbar <= 1 - RECOBAR1) ? Gbar + RECOBAR1 : 1.0f;
                recove = true;
            }
        }
    }
}