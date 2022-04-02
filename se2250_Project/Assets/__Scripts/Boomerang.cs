using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boomerang : MonoBehaviour
{
    bool go;

    GameObject player;

    GameObject playerLocation;

    Transform itemRotate;

    Vector3 location;

    void Start()
    {
        go = false;

        player = GameObject.Find("piratePlayer");

        player.GetComponent<SpriteRenderer>().enabled = false;
        itemRotate = gameObject.transform.GetChild(0);

        location = new Vector3(player.transform.position.x, player.transform.position.y + 1, 0) + player.transform.forward * 2f;

        StartCoroutine(Boom());
    }

    IEnumerator Boom()
    {
        go = true;
        yield return new WaitForSeconds(1.5f);
        go = false;
    }

    void Update()
    {
        itemRotate.transform.Rotate(0, Time.deltaTime * 500, 0);

        if (go)
        {
            player.SetActive(false);
            transform.position = Vector3.MoveTowards(transform.position, location, Time.deltaTime * 40);
        }

        if (!go)
        {
            player.SetActive(true);
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(player.transform.position.x, player.transform.position.y + 1, 0), Time.deltaTime * 40);
        }

        if(!go && Vector3.Distance(player.transform.position, transform.position) < 1.5)
        {
            player.GetComponent<SpriteRenderer>().enabled = true;
            Destroy(this.gameObject);
        }
    }
}
