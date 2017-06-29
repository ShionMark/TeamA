using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


namespace Asuka
{
    public class FuelBar2 : MonoBehaviour
    {

        public string text = "GameOverScene";

        public enum STATE_FUEL{ NORMAL, DAMAGE, RECOVER }
        public STATE_FUEL stateFuel;

        const float fRecoANI = 0.08f;//回復の上昇アニメ
        const float fDameANI = 0.08f;//ダメージの赤ゲージアニメ
        const float DAMAGE1 = 1.0f;//ダメージ
        const float RECOVER1 = 1.0f;//回復量
        const float FUEL_DECRE = 4;//毎秒燃料を減らす大きさ（数が小さいほど早い）


        public static bool bRecoFlg;
        //public GameObject FuelBarGreen;
        public GameObject FuelBar;
        float fDamage, fRecobar, fNowBar;
        float fDEFAULT_SCALE;
        // Use this for initialization
        void Start()
        {
            fDEFAULT_SCALE = fNowBar = FuelBar.transform.localScale.x;
            bRecoFlg = false;
        }

        // Update is called once per frame
        void Update()
        {

            switch (stateFuel)
            {
                case STATE_FUEL.NORMAL:
                    if (fNowBar > 0)
                    {
                        fNowBar -= 1.0f * Time.deltaTime / FUEL_DECRE; //徐々に減らす
                    }
                    else if (fNowBar <= 0)
                    {
                        SceneManager.LoadScene(text);
                    }
                    break;

                case STATE_FUEL.DAMAGE:

                    if (fNowBar > fDamage)
                    {
                        fNowBar -= fDameANI;
                    }
                    else
                    {
                        fNowBar = fDamage;
                        stateFuel = STATE_FUEL.NORMAL;
                    }
                    break;

                case STATE_FUEL.RECOVER:

                    if (fRecobar >= fNowBar && fNowBar < fDEFAULT_SCALE)
                    {
                        fNowBar += fRecoANI;
                    }
                    else
                    {
                        fNowBar = fRecobar;
                        stateFuel = STATE_FUEL.NORMAL;
                    }
                    break;
            }


            FuelBar.transform.localScale = new Vector3(fNowBar, FuelBar.transform.localScale.y, FuelBar.transform.localScale.z);

            if (Input.GetKeyDown(KeyCode.Alpha1) && fNowBar > 0)//ダメージ(1キー)
            {
                fDamage = (fNowBar >= DAMAGE1) ? fNowBar - DAMAGE1 : 0;
                stateFuel = STATE_FUEL.DAMAGE;
            }

            if (bRecoFlg == true && fNowBar > 0 && fNowBar <= fDEFAULT_SCALE)//回復(2キー)
            {
                fRecobar = (fNowBar <= fDEFAULT_SCALE - RECOVER1) ? fNowBar + RECOVER1 : fDEFAULT_SCALE;
                stateFuel = STATE_FUEL.RECOVER;
                bRecoFlg = false;
            }
        }
    }
}