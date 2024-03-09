using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;
    private float minTime = 3f;
    private float maxTime = 5f;
    private float spawnRandomTime;
    // Start is called before the first frame update
    void Start()
    {
     // removed start call and moved it into Void Update.
    }
    void Update()// Invoking spawn method and giving it a random range (I think I could remove the if statement)
    {
        if (!IsInvoking("SpawnRandomBall"))
        {
            Invoke("SpawnRandomBall", Random.Range(minTime, maxTime));
        }
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
       // Crated index random selection by starting at zero and selecting from the index length
        int ballIndex = Random.Range(0, ballPrefabs.Length);
        

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[0].transform.rotation);
    }

}
