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

    // gameobjects
    public GameObject player0;
    public GameObject player1;
    public GameObject player2;

    //ghost combat style
    //Hitbox
    public ContactFilter2D filter;
    private BoxCollider2D hitbox;
    private Collider2D[] hits = new Collider2D[10];

    protected override void Start()
    {
        base.Start();
        
        

        startingPosition = transform.position;
        hitbox = transform.GetChild(0).GetComponent<BoxCollider2D>();
    }

    protected override void FixedUpdate()
    {

        if(player0.activeInHierarchy == true)
        {
            playerTransform = GameObject.Find("mainPlayer").transform;
        }
        if(player1.activeInHierarchy == true)
        {
            playerTransform = GameObject.Find("wizardPlayer").transform;
        }
        if (player2.activeInHierarchy == true)
        {
            playerTransform = GameObject.Find("piratePlayer").transform;
        }
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
            else if (hits[i].tag == "Fighter" && hits[i].name == "wizardPlayer")
            {
                collidingWithPlayer = true;
            }
            else if(hits[i].tag == "Fighter" && hits[i].name == "piratePlayer")
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
        GameManager.instance.experience += xpValue;
        GameManager.instance.ShowText("+" + xpValue + " points!", 20, Color.green, transform.position, Vector3.up*50, 3.0f);
    }

    
}
