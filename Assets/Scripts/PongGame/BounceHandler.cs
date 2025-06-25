using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceHandler : MonoBehaviour
{
    private Ball ball;
    public float speed = 5f;
    private Rigidbody2D rb;
    Vector3 lastVelocity;

    
    private void Awake()
    {
        ball = GetComponent<Ball>();
        rb = GetComponent<Rigidbody2D>();
        
    }

    private void Update()
    {
        lastVelocity = rb.velocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Wall") || collision.collider.CompareTag("Paddle"))
        {
            var speedTwo = lastVelocity.magnitude;
            var direction = Vector3.Reflect(lastVelocity.normalized, collision.contacts[0].normal);
            rb.velocity = direction * speed;
        }
        else if (collision.collider.CompareTag("LeftGoal"))
        {
            ball.ResetBall();
        }
        else if (collision.collider.CompareTag("RightGoal"))
        {
            ball.ResetBall();
        }
    }
}
