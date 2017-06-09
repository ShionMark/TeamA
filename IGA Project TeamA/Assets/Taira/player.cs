using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

    float turn = 0;
    Vector2 startPos;
    Vector2 endPos;
    Vector2 tmpPos;
    

    void Start(){

    }

    void Update(){

        if (Input.GetMouseButtonDown(0)){
            this.startPos = Input.mousePosition;
        }
        if (Input.GetMouseButton(0)){
            this.endPos = Input.mousePosition;
            //if (this.endPos.x == 0){
            //    this.startPos = Input.mousePosition;
            //}
            Calculation();
            if (this.tmpPos == this.endPos){
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

        if (this.turn != 0){
            this.tmpPos = Input.mousePosition;
        }
    }

    void Calculation(){
        this.turn = Mathf.Abs(this.startPos.x - this.endPos.x);
        if (this.startPos.x > this.endPos.x){           //右から左へスワイプ
            this.turn *= (-1.0f); 
        }
         
        float tmpY = Mathf.Abs(this.startPos.y - this.endPos.y);
        if (this.turn > 0) this.turn += Mathf.Abs(tmpY) * 0.005f;
        if (this.turn < 0) this.turn += -(Mathf.Abs(tmpY) * 0.005f);
        this.turn *= 0.005f;
    }
   /*
    
    */
    
}   