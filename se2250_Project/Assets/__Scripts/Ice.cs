using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ice : MonoBehaviour
{
    public int damage = 2;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Fighter")
        {
            if(other.name == "mainPlayer" || other.name == "wizardPlayer" || other.name == "piratePlayer")
            {
                
            }
            else{
                Destroy(other.gameObject);
                Invoke("Destroy",5f); 
            }
        }
    }

    void Update()
    {
        Invoke("Destroy",10f); 
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }
}
