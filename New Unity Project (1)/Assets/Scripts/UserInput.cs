using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : Monobehaviour
{
    public Rigidbody2D bellRigidbody2D;
    public vector2 direction;
    public vector2 yDirection;

    void Update ()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            ballRigidbody2D.AddForce(direction.ForceMode2D.Force);
        }

        if (input.GetKey(KeyCode.LeftArrow))
        {
            ballRigidbody2D.AddForce(-direction.ForceMode2D.Force);
        }

        if (input.Getkey(Keycode.UpArrow))
        {
            ballRigidbody2D.AddForce(ydirection.ForceMode2D.Force);
        }
    }
}