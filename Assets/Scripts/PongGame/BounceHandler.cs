using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AdaptivePerformance.VisualScripting;

public class BounceHandler : MonoBehaviour
{
    private Ball ball;
    public float speed = 5f;
    private Rigidbody2D rb;
    //Vector3 lastVelocity;
    public float maxBounceAngle = 75f;
    
    private void Awake()
    {
        ball = GetComponent<Ball>();
        rb = GetComponent<Rigidbody2D>();
        if (ball == null)
        {
            Debug.LogError("BoumceHandler requires a Ball component on the same GameObject.");
        }
        if (rb == null)
        {
            Debug.LogError("BounceHandler requires a Rigidbody2D component on the same GameObject.");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Wall"))
        {
            Vector2 currentVelocity = rb.velocity;
            Vector2 normal = collision.GetContact(0).normal;
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("LeftGoal"))
        {
            ScoreManager.instance.AddScore(2);
            ball.ResetBall();
        }
        else if (collider.CompareTag("RightGoal"))
        {
            ScoreManager.instance.AddScore(1);
            ball.ResetBall();
        }
    }
}
