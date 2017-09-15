using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TSound;

namespace Asuka
{
    public class Title : MonoBehaviour
    {
        public Button PlayButton, QuitButton;


        void Start()
        {
            Button playbtn = PlayButton.GetComponent<Button>();
            playbtn.onClick.AddListener(StartOnClick);

            Button quitbtn = QuitButton.GetComponent<Button>();
            quitbtn.onClick.AddListener(QuitOnClick);
        }

        // Update is called once per frame
        void Update()
        {

        }

        void StartOnClick()
        {
            TSound.TitleSoundManager.SFlg = true;
            SceneManager.LoadScene("SelectScene");
        }
        void QuitOnClick()
        {
            TSound.TitleSoundManager.SFlg = true;
            Application.Quit();
        }
    }
}