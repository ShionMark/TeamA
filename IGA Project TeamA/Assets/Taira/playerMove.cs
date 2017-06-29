using UnityEngine;
using System.Collections;

public class playerMove : MonoBehaviour {

    float turn = 0;
    Vector2 startPos;
    Vector2 endPos;
    Vector2 tmpPos;
    

    void Start(){

    }

    void Update(){

        if (Input.GetMouseButtonDown(0)||this.endPos.y == 0){
            this.startPos = Input.mousePosition;
        }
        if (Input.GetMouseButton(0)){
            this.endPos = Input.mousePosition;
            if (startPos.y < 0)
            {
                CalculationYMinus();
            }
            else {
                CalculationYPlus();                
            }
            if (this.tmpPos == this.endPos)
            {
                this.turn = 0;
            }
        }
        if (Input.GetMouseButtonUp(0)){
            this.turn = 0;
            this.startPos = new Vector2(0, 0);
            this.endPos = new Vector2(0, 0);
            this.tmpPos = new Vector2(0, 0);
        }
        
        transform.Rotate(0, 0, this.turn);

        this.tmpPos = Input.mousePosition;
    }

    void CalculationYMinus()
    {//Mathf.Sign//比較(+-)
        if (startPos.y > endPos.y) {
            if (startPos.x < endPos.x){
                turn = .1f;
            }else {
                turn = -1f;
            }
        }else {
            if (startPos.x < endPos.x)
            {
                turn = 1f;
            }
            else
            {
                turn = -1f;
            }
        }
    }

    void CalculationYPlus() {
        if (startPos.y > endPos.y)
        {
            if (startPos.x < endPos.x)
            {
                turn = -1f;
            }
            else
            {
                turn = 1f;
            }
        }
        else
        {
            if (startPos.x < endPos.x)
            {
                turn = -1f;
            }
            else
            {
                turn = 1f;
            }
        }
    }
   /*
    
    */
    
}   