using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PirateMovement : MonoBehaviour
{
    public GameObject player;
    bool dash = false;
    bool play = true;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))    // to go back to home
        {
            play = !play;
           // to make player turn invisible or visible if X is clicked
           player.GetComponent<SpriteRenderer>().enabled = !player.GetComponent<SpriteRenderer>().enabled;

        } 

    }
}
