using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public Paddle paddle;
    private Vector3 paddleToBallVector;
    private bool hasStarted = false;

    // Use this for initialization
    void Start()
    {
        // Get difference between paddle and ball pos at the start
        paddleToBallVector = this.transform.position - paddle.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Check if game has started
        if (!hasStarted)
        {
            // Keep ball at same position
            this.transform.position = paddle.transform.position + paddleToBallVector;

            // Give ball velocity (launch) on click
            if (Input.GetMouseButtonDown(0))
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
                hasStarted = true;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (hasStarted)
        {
            // Vector to change velocity of ball each time it hits
            Vector2 tweak = new Vector2(Random.Range(0f, 0.2f), Random.Range(0f, .2f));
            GetComponent<AudioSource>().Play();
            GetComponent<Rigidbody2D>().velocity += tweak;
        }
    }
}
