using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
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
            Destroy(gameObject); // destroy diamond
            SceneManager.LoadScene("Victory"); // Takes you to victory level.
        }
            
    }
}