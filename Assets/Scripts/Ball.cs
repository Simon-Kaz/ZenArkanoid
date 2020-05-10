using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Movement Speed
    public float speed = 100.0f;
    // Paddle
    private GameObject racket;
    private float destructionOffset = 2.0f;
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
        racket = GameObject.Find("racket");
    }

    void FixedUpdate()
    {
        if(BallBelowRacket())
        {
            Destroy(gameObject);
        }
    }

    private bool BallBelowRacket()
    {
        return gameObject.transform.position.y < (racket.transform.position.y - destructionOffset);
    }

    private void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.name == "racket")
        {
            // Calculate hit Factor
            float x = hitFactor(transform.position,
                collider.transform.position,
                collider.collider.bounds.size.x);

            // Calculate direction, set length to 1
            Vector2 direction = new Vector2(x, 1).normalized;

            // Set velocity with direction * speed
            GetComponent<Rigidbody2D>().velocity = direction * speed;
        }
    }

    float hitFactor(Vector2 ballPos, Vector2 racketPos, float racketWidth)
    {
        return (ballPos.x - racketPos.x) / racketWidth;
    }
}