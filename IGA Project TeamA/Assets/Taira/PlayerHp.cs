using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHp : MonoBehaviour {
    
    GameObject ZankiText;
    public float playerMAXHp;
    public static float playerHp;
    int Zanki = 3;

	// Use this for initialization
	void Start () {
        playerHp = playerMAXHp;
        ZankiText = GameObject.Find("Text");
	}
	
	// Update is called once per frame
	void Update () {
        if (playerHp <= 0) {
            Zanki--;
            playerHp = playerMAXHp;
        }
        if (Zanki < 0) {
            SceneManager.LoadScene("TitleScene");
            
        }
     //   ZankiText.GetComponent<Text>().text = "残機 : " + Zanki.ToString();
	}

    
    
}
