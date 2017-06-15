using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MouseDrag : MonoBehaviour 
{

    public GameObject MainGauge;
    public GameObject BackGround;
    void Update()
    {
        Vector3 objectPointInScreen
            = Camera.main.WorldToScreenPoint(this.transform.position);

        Vector3 mousePointInScreen
            = new Vector3(objectPointInScreen.x,
                          Input.mousePosition.y,
                          objectPointInScreen.z);

        Vector3 mousePointInWorld = Camera.main.ScreenToWorldPoint(mousePointInScreen);
        mousePointInWorld.z = this.transform.position.z;
        mousePointInWorld.x = this.transform.position.x;

        this.transform.position = mousePointInWorld;

        //Limit to move
        float DragMAX = MainGauge.transform.position.y * (BackGround.transform.localScale.y
                                                + MainGauge.transform.localScale.y);
        // Get player coordinates
        Vector2 pos = transform.position;

        //Player's position limit
        pos.y = Mathf.Clamp(pos.y, 0, DragMAX);

        // Let the position of the player be the restricted value
        transform.position = pos;
    }
   
}
