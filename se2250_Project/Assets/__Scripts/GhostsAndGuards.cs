using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostsAndGuards : Mover
{
    public int xpValue = 1;         //experience points

    public float triggerLength = 1;
    public float chaseLength = 5; 
    private bool chasing;
    private bool collidingWithPlayer;
    private Transform playerTransform;
    private Vector3 startingPosition;

    //ghost combat style
    //Hitbox
    public ContactFilter2D filter;
    private BoxCollider2D hitbox;
    private Collider2D[] hits = new Collider2D[10];

    protected override void Start()
    {
        base.Start();

        playerTransform = GameObject.Find("mainPlayer").transform;
        startingPosition = transform.position;
        hitbox = transform.GetChild(0).GetComponent<BoxCollider2D>();
    }

    protected override void FixedUpdate()
    {
        //player in range
        if(Vector3.Distance(playerTransform.position, startingPosition) < chaseLength)
        {
            if(Vector3.Distance(playerTransform.position, startingPosition) < triggerLength)
            {
                chasing = true;
            }

            if (chasing)
            {
                if (!collidingWithPlayer)
                {
                    UpdateMotor((playerTransform.position - transform.position).normalized);
                }
            }
            else 
            {
                UpdateMotor(startingPosition - transform.position);
            }
        }
        else 
        {
            UpdateMotor(startingPosition - transform.position);
            chasing = false;
        }

        //overlaps
        collidingWithPlayer = false;
        boxCollider.OverlapCollider(filter, hits);
        for (int i = 0; i < hits.Length; i++)
        {
            if (hits[i] == null){
                continue;
            }

            if (hits[i].tag == "Fighter" && hits[i].name == "mainPlayer")
            {
                collidingWithPlayer = true;
            }

            //clean up array
            hits[i] = null;
        }
    }

    protected override void Death()
    {
        Destroy(gameObject);
        //GameManager.instance.experience += xpValue;
        //GameManager.instance.ShowText();

    }

    
}
