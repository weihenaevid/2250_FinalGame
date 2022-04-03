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


    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.J))
        {
            Instantiate(icePrefab, iceLocation.position, iceLocation.rotation);
            anim.SetTrigger("Swing");   
        }
    }

}
