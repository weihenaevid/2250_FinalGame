using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : Fighter
{
    protected BoxCollider2D boxCollider;
    private Vector3 moveDelta;
    private RaycastHit2D hit;
    public float ySpeed = 0.75f;
    public float xSpeed = 1.0f;

    private Vector3 moveDir;

    private bool facingRight;


    protected virtual void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();

    }

    // private void Dashing()
    // {
    //     // for dashing
       
    // }


    protected virtual void FixedUpdate()
    {
        //  if (Input.GetKeyDown(KeyCode.E))         // if E is pressed
        // {         
        //    transform.position += transform.position * dashLength;

        // }

    }


    protected virtual void UpdateMotor(Vector3 input)     
    {

        // Reset moveDelta
        moveDelta = new Vector3(input.x * xSpeed, input.y * ySpeed, 0);


        // Swap sprite direction
      
            if (moveDelta.x > 0)
            {
                transform.localScale = Vector3.one;
            }
            else if (moveDelta.x < 0)
            {
                transform.localScale = new Vector3(-1, 1, 1);
            }
        
        
        //add push vector
        moveDelta += pushDirection;

        //reduce push force with every frame
        pushDirection = Vector3.Lerp(pushDirection, Vector3.zero, recoverySpeed);

        //Make sure we can move in this direction
        hit = Physics2D.BoxCast(transform.position, boxCollider.size, 0, new Vector2(0, moveDelta.y), Mathf.Abs(moveDelta.y * Time.deltaTime), LayerMask.GetMask("Actor", "Blocking"));
        if (hit.collider == null)
        {
            //player movement
            transform.Translate(0, moveDelta.y * Time.deltaTime, 0);

        }

        hit = Physics2D.BoxCast(transform.position, boxCollider.size, 0, new Vector2(moveDelta.x, 0), Mathf.Abs(moveDelta.x * Time.deltaTime), LayerMask.GetMask("Actor", "Blocking"));
        if (hit.collider == null)
        {
            //player movement
            transform.Translate(moveDelta.x * Time.deltaTime, 0, 0);

        }
    }
}


// void flip(){
//     facingRight = !facingRight;
//     transform.Rotate(0f,180f,0f);
// }