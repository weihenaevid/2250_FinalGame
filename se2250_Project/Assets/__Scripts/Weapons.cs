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
    private Animator anim;
    private float coolDown = 0.5f;//weapon can be swung every 0.5s
    private float lastSwing;

    protected override void Start()
    {
        base.Start();
        spriteRenderer = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    protected override void Update()
    {
        base.Update();

        if(Input.GetKeyDown(KeyCode.Z))
        {   
            if(Time.time - lastSwing > coolDown)
            {
                lastSwing = Time.time;
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
        anim.SetTrigger("Swing");

    }

    public void UpgradeWeapon()
    {
        spriteRenderer.sprite = GameManager.instance.weaponSprite[weaponLevel];


    }

}
