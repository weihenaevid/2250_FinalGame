using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ice : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb;
    //public Tranform endPos;

    // Start is called before the first frame update
    void Start()
    {
//        rb.MovePosition()
        rb.velocity = transform.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
