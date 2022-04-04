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
            //yield WaitForSeconds(anim["Swing"].length * anim["Swing"].speed);
            anim.SetTrigger("Swing");
            Instantiate(icePrefab, iceLocation.position, iceLocation.rotation);
               
        }
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            icePrefab.transform.Rotate(0.0f,-180.0f,0.0f);
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            icePrefab.transform.Rotate(0.0f, 360.0f, 0.0f);
        }
    
    }

}
