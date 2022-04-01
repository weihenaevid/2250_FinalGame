using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons_waterball2 : MonoBehaviour
{
    public Projectile thrownProjectilePrefab;
    private Projectile thrownP;
    public Transform launchOffset;

    private Rigidbody2D _rb;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            thrownP = Instantiate(thrownProjectilePrefab);
            thrownP = Instantiate(thrownP, launchOffset.position, transform.rotation);
            Destroy(thrownP, 2);
        }
    }

    int damage = 30;
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }

        //  Instantiate(impactEffect, transform.position, transform.rotation);

        Destroy(thrownP);
    }
}