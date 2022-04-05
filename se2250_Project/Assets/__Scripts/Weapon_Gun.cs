using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon_Gun : Collidable
{
    public GameObject sword;
    public GameObject gun;
    public Transform firePoint;
    public GameObject bulletPrefab;
    public GameObject wand;
    public Transform iceLocation;
    public GameObject player1, player2, player3;
    public int whichWeapon = 0;

    public int damagePoint = 1;
    public float pushForce = 2.0f;

    void Start()
    {
        if(player1.activeSelf){
            sword.SetActive(true);
            wand.SetActive(false);
            gun.SetActive(false);
        }
        if(player2.activeSelf)
        {
            sword.SetActive(false);
            wand.SetActive(true);
            gun.SetActive(false);
        }        
    }

    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1") && gun.activeSelf)
        {
            Shoot();
        }

        if(player1.activeSelf)
        {
            SwitchWeapon1();
        }
        if(player2.activeSelf)
        {
            SwitchWeapon2();
        }
    }

    public void SwitchWeapon1()
    {
        if(Input.GetKeyDown(KeyCode.G))
        {
                        gun.SetActive(true);   
            sword.SetActive(false);
            wand.SetActive(false);             
        }

        if(Input.GetKeyDown(KeyCode.H))
        {
            gun.SetActive(false);
            sword.SetActive(true);
            wand.SetActive(false);
        }
    }

    public void SwitchWeapon2()
    {
        if(Input.GetKeyDown(KeyCode.G))
        {
            sword.SetActive(false);
            wand.SetActive(false);
            gun.SetActive(true);                
        }

        if(Input.GetKeyDown(KeyCode.J))
        {
            gun.SetActive(false);
            sword.SetActive(false);
            wand.SetActive(true);
        }
    }

    void Shoot()
    {
        if(player1.activeSelf || player2.activeSelf)
        {
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
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

            };

            col.SendMessage("RecieveDamage", dmg);
        }
        
    }
}
