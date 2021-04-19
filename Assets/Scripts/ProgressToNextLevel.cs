using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ProgressToNextLevel : MonoBehaviour
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
            Destroy(gameObject); // destroy diamond
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //takes you to the next level in the stack
        }
            
    }
}
