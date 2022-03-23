using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHitbox : Collidable
{
    public int damage = 1;
    public float pushForce;

    protected override void OnCollide(Collider2D col)
    {
        if (col.tag == "Fighter" && col.name == "mainPlayer")
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
