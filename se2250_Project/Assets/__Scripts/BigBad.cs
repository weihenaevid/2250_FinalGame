using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BigBad : GhostsAndGuards
{

    public float[] grenadeSpeed = { 2.8f, -2.8f };          // for the speed of the grenades
    public float[] grenadeDistance = { 0.30f, 0.25f };      // for the distance from the bug bad (the radius)
    public Transform[] grenade;     // for the position of the grenades
    public GameObject chest;

    private void Update()
    {
        for (int i = 0; i < grenade.Length; i++)
        {
            // so the grendes move around the big bad
            grenade[i].position = transform.position + new Vector3(-Mathf.Cos(Time.time * grenadeSpeed[i]) * grenadeDistance[i], Mathf.Sin(Time.time * grenadeSpeed[i]) * grenadeDistance[i], 0); 
        }
    }

    protected override void Death()
    {
        Destroy(gameObject);
        GameManager.instance.experience += xpValue;
        GameManager.instance.ShowText("+" + xpValue + " points!", 20, Color.green, transform.position, Vector3.up*50, 3.0f);
        chest.transform.position = new Vector3(4.72f, 2.3f, 0);
        chest.SetActive(true);
    }
}
