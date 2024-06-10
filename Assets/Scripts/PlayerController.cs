using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public float speed;
    public float input;
    public float jumpPower;
    private bool grounded;

    void Update()
    {
        input = Input.GetAxisRaw("Horizontal");
        rb2d.velocity = new Vector2(input * speed, rb2d.velocity.y);

        if(Input.GetKey(KeyCode.Space) && grounded)
        {
            Jump();
        }
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
    
}
