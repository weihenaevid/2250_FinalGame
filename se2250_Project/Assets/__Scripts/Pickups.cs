using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickups : MonoBehaviour
{
    public GameObject key1, key2, key3, gPotion, rPotion, chest;//gameObjects the user is interacting with
    public Image imageKey1, imageKey2, imageKey3, imageGPotion, imageRPotion, imageChest;//the images in the inventory bar
    public int powerupsCollected = 0;

    // Start is called before the first frame update
    void Start()
    {   
        imageKey1.enabled = false;
        imageKey2.enabled = false;
        imageKey3.enabled = false;
        imageGPotion.enabled = false;
        imageRPotion.enabled = false;
        imageChest.enabled = false;    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        //if(other.CompareTag("Fighter"))
        if(other.gameObject.tag == "Fighter")
        {
            Debug.Log("pickup");

            //check if this gameObject is key1
                //set visible
            //check if this gameObject is key2
                //set visible
            //check if this gameObject is key3
                //set visible
            //check if this gameObject is gPotion
                //set visible
            //check if this gameObject is rPotion
                //set visible 

            Destroy(other.gameObject);
            
        } 
    }
}
