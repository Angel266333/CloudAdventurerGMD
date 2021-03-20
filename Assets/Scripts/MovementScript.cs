using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    /* Credits for script code - compilation of two scripts:
     * https://forum.unity.com/posts/5931503
     * https://answers.unity.com/questions/754633/how-to-move-an-object-left-and-righ-looping.html
     */

    //adjust this to change speed
    [SerializeField] float vSpeed = 5f;
    [SerializeField] float xSpeed = 5f;

    //adjust this to change how high it goes
    [SerializeField] float height = 25f;

    Vector3 pos;

    public bool vMovement = true;

    public bool xMovement = true;

    private void Start()
    {
        pos = transform.position;
    }

    void Update()
    {
        if (xMovement)
        {
            Vector3 v = pos;
            v.x += xSpeed * Mathf.Sin (Time.time * xSpeed);
            transform.position = v;
        }
        if (vMovement) {
//calculate what the new Y position will be
            float newY = Mathf.Sin(Time.time * vSpeed) * height + pos.y;
//set the object's Y to the new calculated Y
            transform.position = new Vector3(transform.position.x, newY, transform.position.z);
        }

    }
}