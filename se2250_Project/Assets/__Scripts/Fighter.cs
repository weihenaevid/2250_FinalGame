using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fighter : MonoBehaviour
{
    //decalre fields
    public int hitpoint = 10;
    private int _maxHitPoint =10;
    public float recoverySpeed = 0.2f;

    //Immunity
    protected float immuneTime = 1.0f;
    protected float lastImmune;

    //Push direction
    protected Vector3 pushDirection;

    protected virtual void RecieveDamage(Damage dmg){
        if(Time.time - lastImmune > immuneTime){
            lastImmune = Time.time;
            hitpoint -= dmg.damageAmount;
            pushDirection = (transform.position - dmg.origin).normalized * dmg.pushForce;
        }

        if(hitpoint <= 0){
            hitpoint = 0;
            Death();
        }

    }

    protected virtual void Death()
    {
        Invoke("Restart", 2f);

    }


    // Start is called before the first frame update
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
