using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class Portal : Collidable
{

    public string sceneName;
    private Pickups levelUp;
    public Text directText;

    public void Start()
    {
        directText.enabled = false;
    }

    protected override void OnCollide(Collider2D col)
    {
        if(col.name == "mainPlayer" || col.name == "wizardPlayer" || col.name == "piratePlayer")
        {
            if(levelUp.powerupsCollected == 5)
            {
                SceneManager.LoadScene("BigBossLevel");
            }
        }
    }

    void Update()
    {
        if(directText.enabled)
        {
            levelUp.powerupsCollected = 5;
        }
    }
    
}
