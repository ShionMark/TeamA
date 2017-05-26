using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


namespace Itsuki_ver1
{
    public class Pause : MonoBehaviour
    {
        public string text = "TitleScene";

        public Button PauseButton, PlayButton, TitleButton;
        public GameObject OnPanel;
        private bool pauseGame = false;

        void Start()
        {
            OnUnPause();

            Button pausebtn = PauseButton.GetComponent<Button>();
            pausebtn.onClick.AddListener(PauseOnClick);

            Button playbtn = PlayButton.GetComponent<Button>();//スタート(ポーズ中）
            playbtn.onClick.AddListener(PlayOnClick);

            Button titlebtn = TitleButton.GetComponent<Button>();//タイトル(ポーズ中)
            titlebtn.onClick.AddListener(TitleOnClick);
        }

        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape)) pauseGame = !pauseGame;

            if (pauseGame == true)
            {
                OnPause();
            }
            else
            {
                OnUnPause();
            }
        }

        void PauseOnClick()
        {
            pauseGame = true;
        }

        void PlayOnClick()
        {
            pauseGame = false;
        }

        void TitleOnClick()
        {
            SceneManager.LoadScene(text);
        }

        public void OnPause()
        {
            OnPanel.SetActive(true);        // PanelMenuをtrueにする
            Time.timeScale = 0;
            pauseGame = true;
        }

        public void OnUnPause()
        {
            OnPanel.SetActive(false);       // PanelMenuをfalseにする
            //PauseButton.SetActive(true);      // PAUSEボタンをtrueにする
            Time.timeScale = 1;
            pauseGame = false;
        }
    }
}