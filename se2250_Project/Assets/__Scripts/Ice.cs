using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ice : MonoBehaviour
{
       public int damage = 2;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Fighter"))
        {
            Enemy enemy = other.GetComponent<Enemy>();
            if(enemy != null)
            {
                enemy.TakeDamage(damage);
            }
            Destroy(other.gameObject);
        }
    }
}
