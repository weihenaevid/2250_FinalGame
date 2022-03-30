using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTransition : MonoBehaviour
{
    public GameObject Player_1;
    public GameObject Player_2;
    public GameObject Player_3;

    public void Start()
    {
        Player_1.SetActive(true);
        Player_2.SetActive(false);
        Player_3.SetActive(false);    
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))    
        {
            Player_1.SetActive(true);
            Player_2.SetActive(false);
            Player_3.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.O))    
        {
            Player_1.SetActive(false);
            Player_2.SetActive(true);
            Player_3.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.I))    
        {
            Player_1.SetActive(false);
            Player_2.SetActive(false);
            Player_3.SetActive(true);
        }
    }
}
