using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveHitBox : MonoBehaviour
{
    public GameObject MoveObj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Vector2 mousePos = Input.mousePosition;
        if(mousePos.x >= 700f && mousePos.x <= 1300f){
            
            MoveObj.transform.localPosition = new Vector3(mousePos.x-1000f,MoveObj.transform.localPosition.y,MoveObj.transform.localPosition.z);

            Debug.Log(mousePos);
        }
    }
}
