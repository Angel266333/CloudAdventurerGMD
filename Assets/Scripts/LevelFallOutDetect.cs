using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelFallOutDetect : MonoBehaviour
{


    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y < -5f)
        {
            SceneManager.LoadScene(0);
        }  
    }
}
