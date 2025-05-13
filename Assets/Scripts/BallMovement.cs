using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BallMovement : MonoBehaviour
{
    public float speed = 5f;         // Speed of the ball
    public TextMeshProUGUI scoreTxt;
    
    public string sceneName;
    private Rigidbody2D rb;
    private int score = 0;
    private static int brickCount;

    

    private bool isLaunched = false;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.zero;
        brickCount = GameObject.FindGameObjectsWithTag("Brick").Length;
        

    }
    void Update()
    {
        if(!isLaunched && Input.GetKeyDown(KeyCode.W)|| Input.GetKeyDown(KeyCode.UpArrow)){
            LaunchBall();
            isLaunched = true;
        }
        scoreTxt.text = score.ToString();
        if(brickCount == 0)
        {
            SceneManager.LoadScene(sceneName);
        }   
    }
    void LaunchBall()
    {
        

        Vector2 direction = new Vector2(Random.Range(-1f, 1f), 1).normalized;
        rb.velocity = direction * speed;
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Brick"))
        {
            score++;
            brickCount--;
            Destroy(collision.gameObject);
        }
        // Optionally add logic here for sound effects or other collision responses
        //hitting bricks
        // Get current velocity
        Vector2 velocity = rb.velocity;
        // Prevent the ball from moving too vertically or horizontally straight,
        // by slightly tweaking the velocity if angle is too steep or flat.
        float minXVelocity = 0.5f * speed;
        if (Mathf.Abs(velocity.x) < minXVelocity)
        {
            float newX = velocity.x < 0 ? -minXVelocity : minXVelocity;
            velocity.x = newX;
            velocity = velocity.normalized * speed;
            rb.velocity = velocity;
        }
    }

}
