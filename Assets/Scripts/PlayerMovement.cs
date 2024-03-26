using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator animator;
    public SpriteRenderer spriteRenderer;

    private float movSpeed;
    private Vector2 moveDirection;

    private bool sprinting;
    public bool isFlipped;

    private bool stop;

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

        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY).normalized;

        if (moveX < 0)
        {
            isFlipped = true;
            spriteRenderer.flipX = true;
        }
        else if(moveX >= 1)
        {
            isFlipped = false;
            spriteRenderer.flipX = false;
        }

        if (Input.GetKeyDown("left shift"))
        {
            sprinting = true;

        }
        else if (Input.GetKeyUp("left shift"))
            {
            sprinting = false;
        }

    }

    void Move()
    {
        rb.velocity = new Vector2(moveDirection.x * movSpeed, moveDirection.y * movSpeed);
        animator.SetFloat("Speed", (Mathf.Abs(rb.velocity.x) + Mathf.Abs(rb.velocity.y)));

        if (sprinting == true)
        {
            movSpeed = 7;
            animator.SetBool("isSprinting", true);

        }
        else if (sprinting ==false)
        {
            movSpeed = 3;
            animator.SetBool("isSprinting", false);
        }
    }

    public void StopMoving()
    {
        movSpeed = 0f;
        rb.velocity = new Vector2(0, 0);
        animator.SetBool("isSprinting", false);
        animator.SetFloat("Speed", 0); 
    }


    //For the player movement -> help from: https://www.youtube.com/watch?v=u8tot-X_RBI 
    //For player animation -> help from: https://www.youtube.com/watch?v=hkaysu1Z-N8&t=134s
}
