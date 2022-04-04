using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_1 : MonoBehaviour
{
    public float[] xTeleport = {-2.5f, 1f, -2.7f, -0.74f};             // for x positions 
    public float[] yTeleport = {4.07f, 4, 2.86f, 2.25f};                    // for y positions

    public Vector3 starting = new Vector3(0, -0.6f, 0);


    private int i;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))    // to go back to home
        {
            transform.position = new Vector3(starting.x, starting.y, 0);      
        }

        if (Input.GetKeyDown(KeyCode.E))        // to cycle through a few random positions
        {
            i = Random.Range(0, xTeleport.Length);
            transform.position = new Vector3(xTeleport[i], yTeleport[i], 0);
        }
        
    }

}
