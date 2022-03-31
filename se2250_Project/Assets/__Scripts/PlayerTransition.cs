using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTransition : MonoBehaviour
{
    public GameObject player1, player2, player3;
    public int whichCharacter = 1;
    private Transform player;

    public void Start()
    {
        player1.SetActive(true);
        player2.SetActive(false);
        player3.SetActive(false);    
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))    
        {
            SwitchAvatar();
        }
    }
    public void SwitchAvatar ()
    {
        switch(whichCharacter){
            case 1:
                whichCharacter = 2;
                player2.transform.position = player1.transform.position;
                player1.gameObject.SetActive(false);
                player2.gameObject.SetActive(true);
                player3.gameObject.SetActive(false);
                break;

            case 2:
                whichCharacter = 3;
                player3.transform.position = player2.transform.position;
                player1.gameObject.SetActive(false);
                player2.gameObject.SetActive(false);
                player3.gameObject.SetActive(true);
                break;

            case 3:
                whichCharacter = 1;
                player1.transform.position = player3.transform.position;
                player1.gameObject.SetActive(true);
                player2.gameObject.SetActive(false);
                player3.gameObject.SetActive(false);
                break;
        }
    }
}
