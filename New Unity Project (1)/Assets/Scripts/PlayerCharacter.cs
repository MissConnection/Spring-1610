using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnspeed = 45.0f
    private float horizontalInput;
    private float forwardInput;

    void Update ()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical")
        
        transform.translate(Vector3.forward * Time.deltaTime * speed);
        transform.Rotate(Vector3.up, turnspeed * horizontilInput * time.deltaTime);
    }

}
