using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons_Wand : MonoBehaviour
{
    public GameObject icePrefab;
    public Transform iceLocation;

    private float cooldown = 1f;
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
            //yield WaitForSeconds(anim["Swing"].length * anim["Swing"].speed);
            anim.SetTrigger("Swing");
            Instantiate(icePrefab, iceLocation.position, iceLocation.rotation);  
        }    
    }
}
