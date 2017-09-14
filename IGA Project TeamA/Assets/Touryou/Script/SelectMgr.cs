using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace SelectManager
{
    public class SelectMgr : MonoBehaviour
    {

        public GameObject SelectJiki, SelectStage;
        public Button B_Button, P_Button, S_Button, D_Button;
        public Button ONE_Button, TWO_Button, THREE_Button, FOUR_Button, FIVE_Button, Return_Button;

        public static int iSelectStage, iSelectJiki;

        // Use this for initialization
        void Start()
        {
            iSelectStage =
            iSelectJiki = 0;

            SelectJiki.SetActive(true);
            SelectStage.SetActive(false);

            Button b_btn = B_Button.GetComponent<Button>();
            b_btn.onClick.AddListener(B_ButtonOnClick);
            Button p_btn = P_Button.GetComponent<Button>();
            p_btn.onClick.AddListener(P_ButtonOnClick);
            Button s_btn = S_Button.GetComponent<Button>();
            s_btn.onClick.AddListener(S_ButtonOnClick);
            Button d_btn = D_Button.GetComponent<Button>();
            d_btn.onClick.AddListener(D_ButtonOnClick);

            Button one_btn = ONE_Button.GetComponent<Button>();
            one_btn.onClick.AddListener(One_ButtonOnClick);
            Button two_btn = TWO_Button.GetComponent<Button>();
            two_btn.onClick.AddListener(Two_ButtonOnClick);
            Button three_btn = THREE_Button.GetComponent<Button>();
            three_btn.onClick.AddListener(Three_ButtonOnClick);
            Button four_btn = FOUR_Button.GetComponent<Button>();
            four_btn.onClick.AddListener(Four_ButtonOnClick);
            Button five_btn = FIVE_Button.GetComponent<Button>();
            five_btn.onClick.AddListener(Five_ButtonOnClick);

            Button return_Button = Return_Button.GetComponent<Button>();
            Return_Button.onClick.AddListener(Return_ButtonOnClick);
        }

        void B_ButtonOnClick()
        {
            iSelectJiki = 0;
            SelectJiki.SetActive(false);
            SelectStage.SetActive(true);
        }

        void P_ButtonOnClick()
        {
            iSelectJiki = 1;
            SelectJiki.SetActive(false);
            SelectStage.SetActive(true);
        }

        void S_ButtonOnClick()
        {
            iSelectJiki = 2;
            SelectJiki.SetActive(false);
            SelectStage.SetActive(true);
        }

        void D_ButtonOnClick()
        {
            iSelectJiki = 3;
            SelectJiki.SetActive(false);
            SelectStage.SetActive(true);
        }

        void One_ButtonOnClick()
        {
            iSelectStage = 0;
            SceneManager.LoadScene("Main");
        }

        void Two_ButtonOnClick()
        {
            iSelectStage = 1;
            SceneManager.LoadScene("Main");
        }

        void Three_ButtonOnClick()
        {
            iSelectStage = 2;
            SceneManager.LoadScene("Main");
        }

        void Four_ButtonOnClick()
        {
            iSelectStage = 3;
            SceneManager.LoadScene("Main");
        }

        void Five_ButtonOnClick()
        {
            iSelectStage = 4;
            SceneManager.LoadScene("Main");
        }

        void Return_ButtonOnClick()
        {
            SelectJiki.SetActive(true);
            SelectStage.SetActive(false);
        }
    }
}