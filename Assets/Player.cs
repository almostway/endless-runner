using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public bool runBegun;
    public float moveSpeed;
    public int jumpForce;
    public Rigidbody2D rb;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (runBegun == true)
        {
            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
        }
        

        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
        
    }
}
