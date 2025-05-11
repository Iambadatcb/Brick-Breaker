using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float ballSpeed = 3f;
    private Rigidbody2D rb;
    private bool hasStarted =false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity= Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if(hasStarted!)
        {

        if(Input.GetKeyDown(KeyCode.W)||Input.GetKeyDown(KeyCode.UpArrow))
        {
            hasStarted = true;
            Vector2 initialVelocity = new Vector2(0, ballSpeed);
            rb.velocity = initialVelocity;
        }
        }
    }
}
