using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public float speed;
    private float input;
    public float jumpPower;
    private bool grounded;
    private bool isfacingright = true; 
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        input = Input.GetAxisRaw("Horizontal");
        rb2d.velocity = new Vector2(input * speed, rb2d.velocity.y);

        if(Input.GetKey(KeyCode.Space) && grounded)
        {
            Jump();
        }

        if (input > 0 && !isfacingright)
        {
            flip();
        }
            else if (input < 0 && isfacingright)
        {
            flip();
        }

        animator.SetBool("IsRunning", input != 0);
        animator.SetBool("Grounded", grounded);
    }

    private void Jump()
    {
        rb2d.velocity = new Vector2(rb2d.velocity.x, jumpPower);
        grounded = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
            grounded = true;
    }

    private void flip()
    {
        isfacingright = !isfacingright;
        Vector3 thescale = transform.localScale;
        thescale.x *= -1;
        transform.localScale = thescale;
        
    }
}
