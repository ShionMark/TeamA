using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Asuka
{
    public class Title : MonoBehaviour
    {
        public string text = "MainUIScene";

        const int HelpStorage = 1100;
        public Button PlayButton, HelpButton, CHelpButton, QuitButton;
        public GameObject HelpScene;
        int HelpMove;
        bool Helpflg;

        void Start()
        {
            HelpMove = HelpStorage;
            Helpflg = false;

            Button playbtn = PlayButton.GetComponent<Button>();
            playbtn.onClick.AddListener(StartOnClick);

            Button helpbtn = HelpButton.GetComponent<Button>();
            helpbtn.onClick.AddListener(HelpOnClick);

            Button chelpbtn = CHelpButton.GetComponent<Button>();
            chelpbtn.onClick.AddListener(CHelpOnClick);

            Button quitbtn = QuitButton.GetComponent<Button>();
            quitbtn.onClick.AddListener(QuitOnClick);
        }

        // Update is called once per frame
        void Update()
        {

            HelpScene.transform.localPosition = new Vector3(HelpMove, transform.localScale.y, transform.localScale.z);

            if (Helpflg == true && HelpMove > 0) HelpMove -= 50;
            if (Helpflg == false && HelpMove <= HelpStorage) HelpMove += 50;

        }

        void StartOnClick()
        {
            SceneManager.LoadScene(text);
        }
        void HelpOnClick()
        {
            Helpflg = true;
            Debug.Log("Help!!!");
        }
        void CHelpOnClick()
        {
            Helpflg = false;
            Debug.Log("CloseHelp!!!");
        }
        void QuitOnClick()
        {
            Debug.Log("Quit!!!");
            Application.Quit();
        }
    }
}