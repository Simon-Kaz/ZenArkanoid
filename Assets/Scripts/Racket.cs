using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket : MonoBehaviour
{
    // Movement speed
    public float speed = 150;
    private void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        // velocity = move direction * speed
        GetComponent<Rigidbody2D>().velocity = Vector2.right * (horizontalInput * speed);
    }
}
