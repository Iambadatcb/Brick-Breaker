using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject player;
    public GameObject ball;
    public float speed = 2f;
    public float ballSpeed = 3f;
    private Rigidbody2D rb;
    private bool hasStarted =false;
    // Start is called before the first frame update
    void Start()
    {
        ball.transform.position = new Vector3(0,(float)-4.1,0);
        rb = ball.GetComponent<Rigidbody2D>();
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
        if(Input.GetKey(KeyCode.A)||Input.GetKey(KeyCode.LeftArrow))
        {
           player.transform.position = new Vector3(player.transform.position.x - speed*Time.deltaTime, player.transform.position.y, player.transform.position.z); 
        }
        if(Input.GetKey(KeyCode.D)||Input.GetKey(KeyCode.RightArrow))
        {
           player.transform.position = new Vector3(player.transform.position.x + speed*Time.deltaTime, player.transform.position.y, player.transform.position.z); 
        }
    }
}