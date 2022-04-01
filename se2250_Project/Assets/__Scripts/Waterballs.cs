using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waterballs : MonoBehaviour
{
    public float speed = 3f;
    public bool thrown;
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
       
        var direction = -transform.right + Vector3.up;
        GetComponent<Rigidbody2D>().AddForce(direction * speed, ForceMode2D.Impulse);
       

        transform.Translate(offset);
        Destroy(gameObject, 5);
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
