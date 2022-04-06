using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pickups : MonoBehaviour
{
    public GameObject key1, key2, key3, gPotion, rPotion, chest;//gameObjects the user is interacting with
    public Image imageKey1, imageKey2, imageKey3, imageGPotion, imageRPotion, imageChest;//the images in the inventory bar
    public int powerupsCollected = 0;
    public Text directText;
    public GameObject gameOver;
    
    // Start is called before the first frame update
    void Start()
    {   
        imageKey1.enabled = false;
        imageKey2.enabled = false;
        imageKey3.enabled = false;
        imageGPotion.enabled = false;
        imageRPotion.enabled = false;
        imageChest.enabled = false;
        directText.enabled = false;
        gameOver.SetActive(false);

        if(SceneManager.GetActiveScene().name == "BigBossLevel")//if on second level
        {
            imageKey1.enabled = true;
            imageKey2.enabled = true;
            imageKey3.enabled = true;
            imageGPotion.enabled = true;
            imageRPotion.enabled = true;
            imageChest.enabled = false;
            directText.enabled = false;
            gameOver.SetActive(false);
        }    
    }

    // Update is called once per frame
    void Update()
    {
        LevelUpgrade();
    }

    void OnTriggerEnter2D(Collider2D other)//pick up objects
    {
        if(other.CompareTag("Fighter"))//must be a user character
        {
            if(gameObject.name == "key_1" )//check if this gameObject is key1
            {
                imageKey1.enabled = true;
            }
            if(gameObject.name == "key_2")//check if this gameObject is key2
            {
                imageKey2.enabled = true;
            }
            if(gameObject.name == "key_3")//check if this gameObject is key3
            {
                imageKey3.enabled = true;
            }
            if(gameObject.name == "greenPotion")//check if this gameObject is gPotion
            {
                imageGPotion.enabled = true;
            }
            if(gameObject.name == "redPotion")//check if this gameObject is rPotion
            {
                imageRPotion.enabled = true;
            }
            if(gameObject.name == "chest" )//check if this gameObject is chest
            {
                imageChest.enabled = true;
                gameOver.SetActive(true);
            }
            Destroy(gameObject);         
        } 
    }


    void LevelUpgrade()//open portal/enable level up to next scene
    {// all five powerups must be collected
        if(imageKey1.enabled && imageKey2.enabled && imageKey3.enabled && imageGPotion.enabled && imageRPotion.enabled){
            powerupsCollected = 5;
            directText.enabled = true;
        }
    }
}
