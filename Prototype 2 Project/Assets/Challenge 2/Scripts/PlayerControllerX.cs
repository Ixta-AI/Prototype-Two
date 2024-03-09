using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float spawnDelay = 0.8f;
    private bool onDelay = false;
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space)&&!onDelay)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
           
            onDelay = true;
           
            Invoke("delayFunction", spawnDelay);
        }
        
    }
   // reset delay to false (not entirely sure why I need this but I do since it does not work without it)
    void delayFunction()
    {
        onDelay = false;
    }
}
// If space bar and NOT onDelay (meaning is false) spawn dog set delay to true Invoke "delayFunction" After 0.8 sec have passed.