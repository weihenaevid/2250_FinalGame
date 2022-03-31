using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform [] lookAt;     // array of transforms for players
    public GameObject player0;      // rehead
    public GameObject player1;      // wizard
    public GameObject player2;      // pirate


    public float boundX = 0.15f;
    public float boundY = 0.05f;

    private PlayerTransition switchPlayer;
   

    private void LateUpdate()
    {
        Vector3 delta = Vector3.zero;

        // for first player
        if(player0.activeInHierarchy == true)
        {
            float deltaX = lookAt[0].position.x - transform.position.x;
            if (deltaX > boundX || deltaX < -boundX)
            {
                if (transform.position.x < lookAt[0].position.x)
                {
                    delta.x = deltaX - boundX;
                }
                else
                {
                    delta.x = deltaX + boundX;
                }
            }
            float deltaY = lookAt[0].position.y - transform.position.y;
            if (deltaY > boundY || deltaY < -boundY)
            {
                if (transform.position.y < lookAt[0].position.y)
                {
                    delta.y = deltaY - boundY;
                }
                else
                {
                    delta.x = deltaY + boundY;
                }
            }
            transform.position += new Vector3(delta.x, deltaY, 0);
        }

         if (player1.activeInHierarchy == true)             // check if player 2 is selected
        {
            float deltaX1 = lookAt[1].position.x - transform.position.x;
            if (deltaX1 > boundX || deltaX1 < -boundX)
            {
                if (transform.position.x < lookAt[1].position.x)
                {
                    delta.x = deltaX1 - boundX;
                }
                else
                {
                    delta.x = deltaX1 + boundX;
                }
            }
            float deltaY1 = lookAt[1].position.y - transform.position.y;
            if (deltaY1 > boundY || deltaY1 < -boundY)
            {
                if (transform.position.y < lookAt[1].position.y)
                {
                    delta.y = deltaY1 - boundY;
                }
                else
                {
                    delta.x = deltaY1 + boundY;
                }
            }
            transform.position += new Vector3(delta.x, deltaY1, 0);

        } if (player2.activeInHierarchy == true) {      // check if player 2 is selected

            float deltaX2 = lookAt[2].position.x - transform.position.x;
            if (deltaX2 > boundX || deltaX2 < -boundX)
            {
                if (transform.position.x < lookAt[2].position.x)
                {
                    delta.x = deltaX2 - boundX;
                }
                else
                {
                    delta.x = deltaX2 + boundX;
                }
            }
            float deltaY2 = lookAt[2].position.y - transform.position.y;
            if (deltaY2 > boundY || deltaY2 < -boundY)
            {
                if (transform.position.y < lookAt[2].position.y)
                {
                    delta.y = deltaY2 - boundY;
                }
                else
                {
                    delta.x = deltaY2 + boundY;
                }
            }
            transform.position += new Vector3(delta.x, deltaY2, 0);
        }
    }
}
