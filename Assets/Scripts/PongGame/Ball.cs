using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public static Ball Instance;
    public float speed = 5f;
    private Rigidbody2D rb;
    private bool isLaunched = false;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (rb == null)
        {
            Debug.LogError("Ball needs a Rigidbody component!");
        }
        ResetBall();

    }

    // Update is called once per frame
    void Update()
    {
        if (!isLaunched && Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            LaunchBall();
        }

        
    }

    void LaunchBall()
    {
        float xDirection = Random.Range(0, 2) == 0 ? -1f : 1f;
        float yDirection = Random.Range(-1f, 1f);

        Vector2 direction = new Vector2(xDirection, yDirection).normalized;
        rb.velocity = direction * speed;
        isLaunched = true;
    }

    public void ResetBall()
    {
        rb.velocity = Vector2.zero;
        transform.position = Vector3.zero;
        isLaunched = false;
    }

}
