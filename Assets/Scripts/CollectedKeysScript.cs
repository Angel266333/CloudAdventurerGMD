using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollectedKeysScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            other.GetComponent<PlayerScoreScript>().keys++;
            //Add 1 to points.
            Destroy(gameObject); // This destroys the key and the fence.
        }
    }
 
}
    