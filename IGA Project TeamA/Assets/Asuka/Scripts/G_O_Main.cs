using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class G_O_Main : MonoBehaviour
{
    public Button TitleButton;

    // Use this for initialization
    void Start()
    {
        Button titbtn = TitleButton.GetComponent<Button>();
        titbtn.onClick.AddListener(TitleOnClick);

    }

    void TitleOnClick()
    {
        SceneManager.LoadScene("TitleScene");
    }
}