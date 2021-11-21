using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public Animator animator;
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        
        //animaatio
        animator.SetFloat("vert", Mathf.Abs(movement.y));
        animator.SetFloat("horiz", Mathf.Abs(movement.x));

        //Flip the Character
        Vector3 charScale = transform.localScale;
        if (Input.GetAxis("Horizontal") <  0) {
            charScale.x = -4;
        }
        if (Input.GetAxis("Horizontal") > 0) {
            charScale.x = 4;
        }
        transform.localScale = charScale;
    }

    void FixedUpdate()
    {
        //Movement
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}