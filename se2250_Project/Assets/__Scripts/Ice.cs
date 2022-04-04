using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ice : MonoBehaviour
{
    public int damage = 2;
    private string[] chars = {"mainPlayer", "wizardPlayer", "piratePlayer"};

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Fighter")
        {
            if(other.name == "mainPlayer" || other.name == "wizardPlayer" || other.name == "piratePlayer")
            {
                
            }
            else{
                Destroy(other.gameObject);
            }
        }
    
    }
}
