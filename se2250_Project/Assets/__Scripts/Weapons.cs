using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : Collidable
{
    //damage structure
    public int damagePoint = 1;
    public float pushForce = 2.0f;
    

    //Upgrade
    public int weaponLevel = 0;
    private SpriteRenderer spriteRenderer;

    //Swing
    private Animator _anim;
    private float _coolDown = 0.5f;//weapon can be swung every 0.5s
    private float _lastSwing;

    protected override void Start()
    {
        base.Start();
        spriteRenderer = GetComponent<SpriteRenderer>();
        _anim = GetComponent<Animator>();
    }

    protected override void Update()
    {
        base.Update();

        if(Input.GetKeyDown(KeyCode.Z))
        {   
            if(Time.time - _lastSwing > _coolDown)
            {
                _lastSwing = Time.time;
                Swing();
            }
        }
    }

    protected override void OnCollide(Collider2D col)
    {
        if (col.tag == "Fighter")
        {
            if (col.name == "mainPlayer") 
                return;
            else if (col.name == "piratePlayer")
                return;

            //create a new damage object
            Damage dmg = new Damage
            {
                damageAmount = damagePoint,
                origin = transform.position,
                pushForce = pushForce,

            };

            col.SendMessage("RecieveDamage", dmg);
        }
        
    }

    private void Swing()
    {  
        _anim.SetTrigger("Swing");

    }

}
