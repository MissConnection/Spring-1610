using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{
    public Rigidbody2D ballRigidbody2D;
    public vector2 direction;
    public vector2 yDirection;

    private vector2 direction;
    private vector2 direction;

    void Update()
    {
        direction.x = Input.GetAxis("Horizontal") * speed;
        ballRigidbody2D.AddForce(direction, ForceMode2D.Force);

        if (Input.GetButtonDown("Jump"))
        {
            yDirection.y = jumpForce;
            ballRigidbody2D.AddForce(yDirection, ForceMode2D.Force);
        }
    }