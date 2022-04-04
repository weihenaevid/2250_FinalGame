using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : Collidable
{

    public string sceneName;
    Pickups levelUp;

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
    
}
