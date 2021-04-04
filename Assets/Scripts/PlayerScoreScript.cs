using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScoreScript : MonoBehaviour
{
    public int points = 0;
    public int keys = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(16, 16, 100, 20), "Coins : " + points);
        GUI.Label(new Rect(16, 36, 100, 20), "Keys : " + keys);
    }
}
