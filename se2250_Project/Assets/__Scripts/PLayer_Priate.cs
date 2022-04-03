using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayer_Priate : MonoBehaviour
{
    public GameObject player;
    // public Sprite Hide;
    // public Sprite pirate;

    bool dash = false;
    bool play = true;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))    // to go back to home
        {
            play = !play;
           // to make player turn invisible or visible if X is clicked
           player.GetComponent<SpriteRenderer>().enabled = !player.GetComponent<SpriteRenderer>().enabled;
            // if(play == true){
            //      this.gameObject.GetComponent<SpriteRenderer>().sprite = Hide;
                 
            // }
            // else if (play == true){
            //     this.gameObject.GetComponent<SpriteRenderer>().sprite = pirate;
                
            // }
           

        } 

    }
}
