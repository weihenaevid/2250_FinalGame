using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    float moveSpeed = 7f;
    Rigidbody2D rb;

    //Player target;
    public Transform target;
    Vector2 moveDirection;

    // Use this for initialization
    void Start() 
    {
    rb = GetComponent<Rigidbody2D> ();
    target = GameObject.Find("mainPlayer").transform;
    moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
    rb.velocity = new Vector2 (moveDirection.x, moveDirection.y);
    Destroy (gameObject, 3f);
    }

    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.gameObject.name.Equals ("mainPlayer"))
        {
            Debug.Log("Hit");
            Destroy(gameObject);
        }
    }
}
