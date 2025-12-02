using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    [field : SerializeField]private float moveSpeed = 5f;
    [field : SerializeField]private bool isInvulnerable = false;
    private float jumpForce = 10f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocityY);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocityX, jumpForce);
        }
    }

    public void SetMoveSpeed(float newSpeed)
    {
        moveSpeed *= newSpeed;
        newSpeed =2f;
    }

    public void SetInerable(bool inerable)
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        
    }


}
