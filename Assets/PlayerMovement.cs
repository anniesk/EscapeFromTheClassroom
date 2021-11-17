using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Experimental.Input;


public class PlayerMovement : MonoBehaviour
{
   /* public CursorControls controls;

    private void Awake()
    {
        controls.Keyboard.rightArrow.performed += _ => moveRight();
        controls.Keyboard.leftArrow.performed += _ => moveRight();
        controls.Keyboard.upArrow.performed += _ => moveRight();
        controls.Keyboard.downArrow.performed += _ => moveRight();
    }

    void moveRight()
    {
        Debug.Log("Moved right");
    }

    void moveLeft()
    {
        Debug.Log("Moved left");
    }

    void moveUp()
    {
        Debug.Log("Moved up");
    }

    void moveDown()
    {
        Debug.Log("Moved down");
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }*/

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
    }
    void FixedUpdate()
    {
        //Movement
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}