using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;
    public int xpValue = 1;             //experience points

    
    public void TakeDamage(int damage)
    {
        health -= damage;
        if(health <=0)
        {
            Die();
        }
    }

    void Die(){
        //deathEffect
        Destroy(gameObject);
        GameManager.instance.experience += xpValue;
        GameManager.instance.ShowText("+" + xpValue + " points!", 20, Color.green, transform.position, Vector3.up*50, 3.0f);
    }
}
