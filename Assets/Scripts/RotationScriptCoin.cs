using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScriptCoin : MonoBehaviour
{
    // Tutorial used: www.youtube.com/watch?v=AIcDUqFcwX4 - Unity3D - Rotating Item
    // Update is called once per frame
    float rotationSpeed = 50.0f;
    void Update()
    {
        transform.Rotate(new Vector3(Time.deltaTime * rotationSpeed, 0, 0));
    }
}
