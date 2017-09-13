using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectScript : MonoBehaviour {

    public GameObject SelectJiki, SelectStage;
    public Button B_Button, P_Button, S_Button, D_Button;
    // public static char Status;

    // Use this for initialization
    void Start () {

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
    }

    void B_ButtonOnClick()
    {
        Debug.Log("0");
        ChangeSelect();
    }

    void P_ButtonOnClick()
    {
        Debug.Log("1");
        ChangeSelect();
    }

    void S_ButtonOnClick()
    {
        Debug.Log("2");
        ChangeSelect();
    }

    void D_ButtonOnClick()
    {
        Debug.Log("3");
        ChangeSelect();
    }

    void ChangeSelect()
    {
        SelectJiki.SetActive(false);
        SelectStage.SetActive(true);
    }

}
