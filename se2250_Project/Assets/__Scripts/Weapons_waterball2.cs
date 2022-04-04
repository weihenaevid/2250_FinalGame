using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons_waterball2 : MonoBehaviour
{
    public Projectile thrownProjectilePrefab;
    private Projectile _thrownP;
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
            _thrownP = Instantiate(thrownProjectilePrefab);
            _thrownP = Instantiate(_thrownP, launchOffset.position, transform.rotation);
            Destroy(_thrownP, 2);
        }
    }
}
