using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHitbox : Collidable
{
    public int damage = 1;
    public float pushForce; 

    protected override void OnCollide(Collider2D col)
    {
        string[] chars = {"mainPlayer", "wizardPlayer", "piratePlayer"};

        for (int i = 0; i < chars.Length; i++)
        {
            if (col.tag == "Fighter" && col.name == chars[i])
        {
            Damage dmg = new Damage
            {
                damageAmount = damage,
                origin = transform.position,
                pushForce = pushForce
            };
            col.SendMessage("RecieveDamage", dmg);
        }
            
        }
        
    }
}
