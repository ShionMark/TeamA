using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


namespace Asuka
{
    public class HPBar : MonoBehaviour
    {
        private const float GBARANIME = 0.01f;//回復の上昇アニメ(数が小さいほど遅い)
        private const float RBARANIME = 0.01f;//ダメージの赤ゲージアニメ(数が小さいほど遅い)
        public static readonly float[] DAMAGE1 = new float[2] { 0.01f, 0.05f };
        public static int HitPattern = 0;
        public static readonly float RECOBAR1 = 0.30f;//回復量
        const int iMAXBAR = 1;
        const int iMINBAR = 0;

        public static GameObject FuelBarGreen, FuelBarRed;

        public static float fRecobar;
        public static bool bdamage, brecove;

        // Use this for initialization
        void Start()
        {
            FuelBarGreen = GameObject.Find("HPBARGREEN");
            FuelBarRed = GameObject.Find("HPBARRED");
            bdamage = false;
            brecove = false;
        }

        // Update is called once per frame
        void Update()
        {
            //緑と赤のバーが０になればゲームオーバー
            if (FuelBarGreen.transform.localScale.x <= iMINBAR && FuelBarRed.transform.localScale.x <= iMINBAR) SceneManager.LoadScene("GameOverScene");


            if (bdamage == true)//ダメージ
            {
                //一旦緑のバーをダメージ分減らし、その後赤のバーが徐々に減っていく処理
                if (FuelBarRed.transform.localScale.x >= FuelBarGreen.transform.localScale.x)
                {
                    FuelBarRed.transform.localScale -= new Vector3(RBARANIME, 0, 0);
                }
                else
                {
                    FuelBarRed.transform.localScale = FuelBarGreen.transform.localScale;
                    bdamage = false;
                }
            }

            if (brecove == true)//回復
            {
                 FuelBarRed.transform.localScale = FuelBarGreen.transform.localScale;//緑のバーと赤のバーを同じ大きさにする
                //緑のバーが回復量、または最大量になるまで徐々に増やす
                if (FuelBarGreen.transform.localScale.x <= fRecobar && FuelBarGreen.transform.localScale.x < iMAXBAR)
                {
                    //最大量を大幅に超えそうなら強制的に最大値にする、ならなければ徐々に増やす
                    FuelBarGreen.transform.localScale = (FuelBarGreen.transform.localScale.x <= iMAXBAR - GBARANIME) ? FuelBarGreen.transform.localScale + new Vector3(GBARANIME, 0.0f, 0.0f) : new Vector3(iMAXBAR, 1.0f, 1.0f);
                }
                else
                {
                    brecove = false;
                }
            }

            if (Input.GetKeyDown(KeyCode.Alpha1)) DAMAGE();//ダメージ(1キー)

            if (Input.GetKeyDown(KeyCode.Alpha2)) RECO();//回復(2キー)


        }

        public static void DAMAGE()
        {
            if (FuelBarGreen.transform.localScale.x > 0)
            {
                FuelBarGreen.transform.localScale = (FuelBarGreen.transform.localScale.x >= DAMAGE1[HitPattern]) ? FuelBarGreen.transform.localScale -= new Vector3(DAMAGE1[HitPattern], 0.0f, 0.0f) : new Vector3(iMINBAR, 1.0f, 1.0f);
                bdamage = true;
            }
        }

        public static void RECO()
        {
            if (FuelBarGreen.transform.localScale.x > 0 && FuelBarGreen.transform.localScale.x <= 1)
            {
                fRecobar = (FuelBarGreen.transform.localScale.x <= 1 - RECOBAR1) ? FuelBarGreen.transform.localScale.x + RECOBAR1 : 1.0f;
                brecove = true;
            }
        }
    }
}