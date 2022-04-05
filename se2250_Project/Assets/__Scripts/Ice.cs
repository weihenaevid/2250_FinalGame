using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ice : MonoBehaviour
{
    public int damage = 2;

    void OnTriggerEnter2D(Collider2D other)
    {
        Enemy enemy = other.GetComponent<Enemy>();
        if (other.tag == "Fighter")
        {
            if(other.name == "mainPlayer" || other.name == "wizardPlayer" || other.name == "piratePlayer")
            {
                
            }
            else{
                enemy.TakeDamage(damage);
                Invoke("Destroy",5f); 
            }
        }
    }

    void Update()
    {
        Invoke("Destroy",10f); 
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }
}
