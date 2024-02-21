using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator animator;
    public SpriteRenderer spriteRenderer;

    public float movSpeed;
    private Vector2 moveDirection;


    void Start()
    {

        spriteRenderer = GetComponent<SpriteRenderer>();

        
    }

    
    void Update()
    {
        ProcessInputs();

    }

    void FixedUpdate()
    {
        //for Physics Calculations
        Move();
    }

    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        //spriteRenderer.flipX = rb.velocity.x < 0f;

        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY).normalized;

        if (moveX < 0)
        {
            spriteRenderer.flipX = true;
        }
        else if(moveX >= 1)
        {
            spriteRenderer.flipX = false;
        }
    }

    void Move()
    {
        rb.velocity = new Vector2(moveDirection.x * movSpeed, moveDirection.y * movSpeed);
        animator.SetFloat("Speed", (Mathf.Abs(moveDirection.x) + Mathf.Abs(moveDirection.y)));
    }


    //For the player movement -> help from: https://www.youtube.com/watch?v=u8tot-X_RBI 
    //For player animation -> help from: https://www.youtube.com/watch?v=hkaysu1Z-N8&t=134s
}
