using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : Collidable
{

    public string sceneName;

    protected override void OnCollide(Collider2D col)
    {
        if(col.name == "mainPlayer" || col.name == "wizardPlayer" || col.name == "piratePlayer")
        {
            //teleport the player
            //string sceneName = 
            SceneManager.LoadScene("BigBossLevel");
        }
    }
    
}
