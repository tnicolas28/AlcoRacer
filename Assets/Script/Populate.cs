using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Populate : MonoBehaviour
{
    [Header("Spawn Points")]
    public GameObject spawnPointOne;
    public GameObject spawnPointTwo;

    [Header("Beer")]
    public GameObject beer;
    public bool isSpawnAllowed = true;


    private void Start()
    {
        if (!isSpawnAllowed) return;

        int spawnRate = Random.Range(0, 3); //Une chance sur trois
        if(spawnRate == 0)
        {
            int rnd = Random.Range(0, 2);
            if (rnd == 1)
            {
                SpawnSomething(beer, spawnPointOne);
            }
            else
            {
                SpawnSomething(beer, spawnPointTwo);
            }
        }
        
    }


    void SpawnSomething(GameObject beer, GameObject spawnPoint)
    {
        GameObject go = Instantiate(
                            beer,
                            spawnPoint.transform.position,
                            Quaternion.identity
                        );
        go.transform.SetParent(transform);
    }
}
