using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveforward : MonoBehaviour
{
    public float speed = 40f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   // forward movement for food item
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
