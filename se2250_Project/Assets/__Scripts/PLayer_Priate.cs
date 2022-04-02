using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayer_Priate : MonoBehaviour
{
    public float min = 2f;
    public float max = 3f;

    // Use this for initialization
    void Start()
    {

        min = transform.position.y;
        max = transform.position.y + 0.1f;
        

    }

    public void Jump()
    {
        transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time / 2, max - min) + min, transform.position.z);
    }

    public GameObject boomer;

    private void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.X))    // to go back to home
        {
            GameObject clone;
          //  clone = Instantiate(boomer, new Vector3(transform.position.x, transform.position.y, 0), transform.rotation) as GameObject;
            Destroy(Instantiate(boomer, new Vector3(transform.position.x, transform.position.y, 0), transform.rotation) as GameObject, 4f);
        }

    }
}
