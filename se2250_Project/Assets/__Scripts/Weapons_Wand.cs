using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private float cooldown = 1f;
    private float lastSwing;
    
    //swing
    private Animator anim;

    //upgrade
    private SpriteRenderer SpriteRenderer;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.J))
        {
            if(Time.time - lastSwing > cooldown)
            {
                lastSwing = Time.time;
                Swing();
            }   
        }
    }

    private void Swing()
    {
        anim.SetTrigger("Swing");
    }
}
