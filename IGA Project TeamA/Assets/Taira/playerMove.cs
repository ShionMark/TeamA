using UnityEngine;
using System.Collections;
using Shooting;

public class playerMove : MonoBehaviour {

    const int PLAYER_MAX = 4;

    float turn = 0;
    Vector2 startPos;
    Vector2 endPos;
    Vector2 tmpPos;

    public GameObject[] iNowMMachine;
    public GameObject[] iNowSMachine;

    void Start(){
        iNowMMachine[Shooting_2.iNowChar].SetActive(true);  //今の自機を映す
        iNowSMachine[Shooting_2.iNowChar].SetActive(true);  //今の子機を映す

        for (int i = 0; i <= PLAYER_MAX - 1; i++)//それ以外の自機と子機を消す
        {
            if (i != Shooting_2.iNowChar)
            {
                iNowMMachine[i].SetActive(false);
                iNowSMachine[i].SetActive(false);
            }
        }
    }

    void Update(){
        
     //   デバッグ用
        if (Input.GetKey(KeyCode.LeftArrow)) turn = 2;
        if (Input.GetKey(KeyCode.RightArrow)) turn = -2;
        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow)) turn = 0;


        if (Input.GetMouseButtonDown(0)||endPos.y ==960){
            this.startPos = Input.mousePosition;
        }
        if (Input.GetMouseButton(0)){
            this.endPos = Input.mousePosition;
            Calculation();
        }
        if (Input.GetMouseButtonUp(0)){
            this.turn = 0;
            this.startPos = new Vector2(0, 0);
            this.endPos = new Vector2(0, 0);
            this.tmpPos = new Vector2(0, 0);
        }
        if (endPos == tmpPos) {
            turn = 0;
        }
        
        
        transform.Rotate(0, 0, this.turn);

        this.tmpPos = Input.mousePosition;
    }

    void Calculation() {
        if (startPos.y > endPos.y)
        {
            if (startPos.x < endPos.x)
            {
                turn = Mathf.Abs(Mathf.Abs(startPos.x) - Mathf.Abs(endPos.x));
            }
            else
            {
                turn = -Mathf.Abs(Mathf.Abs(startPos.x) - Mathf.Abs(endPos.x));
            }
        }
        else
        {
            if (startPos.x < endPos.x)
            {
                turn = Mathf.Abs(Mathf.Abs(startPos.x) - Mathf.Abs(endPos.x));
            }
            else
            {
                turn = -Mathf.Abs(Mathf.Abs(startPos.x) - Mathf.Abs(endPos.x));
            }
        }
        turn *= 0.01f;
        if (startPos.y >960) turn *= -1;
    }

    
    
   /*
    
    */
    
}   