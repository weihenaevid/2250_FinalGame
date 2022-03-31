using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform lookAt; //need to fix
    //private Transform lookAt;
    public Transform lookAt1, lookAt2, lookAt3;

    public float boundX = 0.15f;
    public float boundY = 0.05f;

    private PlayerTransition switchPlayer;

    // private void Update()
    // {
    //     if(switchPlayer.whichCharacter == 2){
    //         lookAt.transform.position = lookAt2.transform.position;
    //     }
    //     else if (switchPlayer.whichCharacter == 3){
    //         lookAt.transform.position = lookAt3.transform.position;
    //     }
    //     else {
    //         lookAt.transform.position = lookAt1.transform.position;
    //     }
    // }    

    private void LateUpdate()
    {
        Vector3 delta = Vector3.zero;

        //this is to check if we're inside the bounds on the Y axis
        // float deltaX = lookAt.position.x - transform.position.x;//x player1
        //     if(deltaX > boundX || deltaX < -boundX)
        //     {
        //         if(transform.position.x < lookAt.position.x)
        //         {
        //             delta.x = deltaX - boundX;
        //         }
        //         else 
        //         {
        //             delta.x = deltaX + boundX;
        //         }
        //     }
        //     float deltaY = lookAt.position.y - transform.position.y;//y player1
        //     if(deltaY > boundY || deltaY < -boundY)
        //     {
        //         if(transform.position.y < lookAt.position.y)
        //         {
        //             delta.y = deltaY - boundY;
        //         } else 
        //         {
        //             delta.x = deltaY + boundY;
        //         }
        //     }
        //     transform.position += new Vector3(delta.x, deltaY, 0);

        if(switchPlayer.whichCharacter == 2)
        {
            float deltaX2 = lookAt2.position.x - transform.position.x;//x player1
            if(deltaX2 > boundX || deltaX2 < -boundX)
            {
                if(transform.position.x < lookAt2.position.x)
                {
                    delta.x = deltaX2 - boundX;
                }
                else 
                {
                    delta.x = deltaX2 + boundX;
                }
            }
            float deltaY2 = lookAt2.position.y - transform.position.y;//y player1
            if(deltaY2 > boundY || deltaY2 < -boundY)
            {
                if(transform.position.y < lookAt2.position.y)
                {
                    delta.y = deltaY2 - boundY;
                } else 
                {
                    delta.x = deltaY2 + boundY;
                }
            }
            transform.position += new Vector3(delta.x, deltaY2, 0);
        }
        else if(switchPlayer.whichCharacter == 3)
        {
            float deltaX3 = lookAt3.position.x - transform.position.x;//x player1
            if(deltaX3 > boundX || deltaX3 < -boundX)
            {
                if(transform.position.x < lookAt3.position.x)
                {
                    delta.x = deltaX3 - boundX;
                }
                else 
                {
                    delta.x = deltaX3 + boundX;
                }
            }
            float deltaY3 = lookAt3.position.y - transform.position.y;//y player1
            if(deltaY3 > boundY || deltaY3 < -boundY)
            {
                if(transform.position.y < lookAt3.position.y)
                {
                    delta.y = deltaY3 - boundY;
                } else 
                {
                    delta.x = deltaY3 + boundY;
                }
            }
            transform.position += new Vector3(delta.x, deltaY3, 0);
        }
        else
        {
        //this is to check if we're inside the bounds on the Y axis
        float deltaX1 = lookAt1.position.x - transform.position.x;//x player1
            if(deltaX1 > boundX || deltaX1 < -boundX)
            {
                if(transform.position.x < lookAt1.position.x)
                {
                    delta.x = deltaX1 - boundX;
                }
                else 
                {
                    delta.x = deltaX1 + boundX;
                }
            }
            float deltaY1 = lookAt1.position.y - transform.position.y;//y player1
            if(deltaY1 > boundY || deltaY1 < -boundY)
            {
                if(transform.position.y < lookAt1.position.y)
                {
                    delta.y = deltaY1 - boundY;
                } else 
                {
                    delta.x = deltaY1 + boundY;
                }
            }
            transform.position += new Vector3(delta.x, deltaY1, 0);
        }

        
    }
}
