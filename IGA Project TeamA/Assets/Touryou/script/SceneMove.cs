using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneMove : MonoBehaviour {

    public Button StageButton;
    
	// Use this for initialization
	void Start () {
        Button titbtn = StageButton.GetComponent<Button>();
        titbtn.onClick.AddListener(StageOnClick);
	}

    // Update is called once per frame
    public void StageOnClick()
    {
            //yield return new WaitForSeconds(3f);
            SceneManager.LoadScene("Main");
        
    }
}