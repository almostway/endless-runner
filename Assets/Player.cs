using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public bool runBegun;
    public float moveSpeed;
    public int jumpForce;
    
    public Rigidbody2D rb;
    
    private bool isGrounded;
    public float groundCheckDistance;
    public LayerMask whatIsGround;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (runBegun == true)
            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);

        isGrounded = Physics2D.Raycast(transform.position, Vector2.down, groundCheckDistance, whatIsGround);

        CheckInput();

    }

    private void CheckInput()
    {
        if (Input.GetButtonDown("Fire2"))
            runBegun = true;

        if (Input.GetButtonDown("Jump") && isGrounded)
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }
    
    /// <summary>
    /// Callback to draw gizmos that are pickable and always drawn.
    /// </summary>
    void OnDrawGizmos()
    {
        Gizmos.DrawLine(transform.position, new Vector2(transform.position.x, transform.position.y - groundCheckDistance));
    }
}
