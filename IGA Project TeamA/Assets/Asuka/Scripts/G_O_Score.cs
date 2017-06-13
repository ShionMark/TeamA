using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Asuka;

public class G_O_Score : MonoBehaviour
{

    Text ScoNumText;

    // Use this for initialization
    void Start()
    {
        ScoNumText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        ScoNumText.text = Asuka.Score.score.ToString(); //表示
    }
}
