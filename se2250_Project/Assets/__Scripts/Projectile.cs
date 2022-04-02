using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
 
    public float speed = 3f;
    public bool thrown;
    public Vector3 offset;
    public int damage = 2;


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

    void OnTriggerEnter2D(Collider2D hit)      // so the waterball destroys once it hitas the opponent
    {
        if (hit.tag == "Fighter")
        {
            Debug.Log(hit.name); 
            Destroy(gameObject);
        }

        Enemy enemy = hit.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }

    }
}
