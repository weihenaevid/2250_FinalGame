using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class Portal : Collidable
{

    public string sceneName;
    public Text directText;

    protected override void OnCollide(Collider2D col)
    {
        if(col.name == "mainPlayer" || col.name == "wizardPlayer" || col.name == "piratePlayer")
        {
            if(directText.enabled)
            {
                SceneManager.LoadScene("BigBossLevel");
            }
        }
    }    
}
