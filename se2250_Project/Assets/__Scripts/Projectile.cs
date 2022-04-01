using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
 
    public float speed = 3f;
    public bool thrown;
    public Vector3 offset;

    // Start is called before the first frame update
    private void Start()
    {
        var direction = -transform.right + Vector3.up;
        GetComponent<Rigidbody2D>().AddForce(direction * speed, ForceMode2D.Impulse);

        transform.Translate(offset);
      //  Destroy(gameObject, 5);
    }

    // Update is called once per frame
    public void Update()
    {
        transform.position += -transform.right * speed * Time.deltaTime;
    }
}
