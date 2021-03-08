using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public float moveSpeed;

    private Rigidbody2D rb;
    public Animator animator;

    Vector2 movement;
    private bool facingRight = true;
    public bool movable = true;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //inputs
        if (IsMovable())
        {
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");
            
            //animate
            if (movement.x > 0 && !facingRight) FlipCharacter();
            else if (movement.x < 0 && facingRight) FlipCharacter();
        }
        else
        {
            movement.x = 0;
            movement.y = 0;
        }

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    private void FixedUpdate()
    {
        //Moving
        rb.MovePosition(rb.position + movement * moveSpeed);
    }

    private void FlipCharacter()
    {
        facingRight = !facingRight;
        transform.Rotate(0f, 180f, 0f);
    }

    public void Lose()
    {
        movable = false;
    }

    public bool IsMovable()
    {
        return movable;
    }
}
