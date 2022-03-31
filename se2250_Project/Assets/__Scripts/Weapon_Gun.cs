using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon_Gun : MonoBehaviour
{
    public GameObject sword;
    public GameObject gun;
    public Transform firePoint;
    public GameObject bulletPrefab;

    void Start()
    {
        sword.SetActive(true);
        gun.SetActive(false);
    }

    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))//mouse 0 = left mouse
        {
            Shoot();
        }

        SwitchWeapon();
    }

    public void SwitchWeapon()
    {
        if(Input.GetKeyDown(KeyCode.G))
        {
            if(sword == true )//switch from sword to gun setting
            {
                sword.SetActive(false);
                gun.SetActive(true);
            }
            
        }

        if(Input.GetKeyDown(KeyCode.H))
        {
            if(gun == true )//switch from sword to gun setting
                {
            gun.SetActive(false);
            sword.SetActive(true);
                }
        }
    }


    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
