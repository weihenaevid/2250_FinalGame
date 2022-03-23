using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public Transform[] ghostLocations;       // for the locations
                                        // public GameObject[] prefabSpawn;    // for the prefab of what should be spawned

    public Transform[] knightLocations;
    public GameObject ghostPrefab;
    public GameObject knightPrefab;

    public GameObject[] cloneSpawned;   // for what is spawned

    // public int numGhosts = 7;



    void spawnGhosts()
    {
        for (int i = 0; i < ghostLocations.Length; i++)
        {
            cloneSpawned[0] = Instantiate(ghostPrefab, ghostLocations[i].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
        }

    }

    void spawnKnights()
    {
        for(int i = 0; i < knightLocations.Length; i++)
        {
            cloneSpawned[0] = Instantiate(knightPrefab, knightLocations[i].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
        }
    }

    // Start is called before the first frame update
    void Start()        // should be spawned once game is started
    {
        spawnGhosts();
        spawnKnights();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
