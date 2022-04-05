using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons_Wand : MonoBehaviour
{
    public GameObject icePrefab;
    public Transform iceLocation;

    private float lastSwing;
    
    //swing
    private Animator anim;

    //upgrade
    private SpriteRenderer SpriteRenderer;


    public void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    public void Update()
    {
        if(Input.GetKey(KeyCode.N))
        {        
            anim.SetTrigger("Swing");
            Invoke("Blast",0.5f);
  
        }    
    }

    public void Blast()
    {
        Instantiate(icePrefab, iceLocation.position, iceLocation.rotation);
    }
}
