using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Variables
    [SerializeField] float speed;
    [SerializeField] float jumpForce;
    private Rigidbody2D rigid2dObjectRef;
    

    bool grounded;
    [SerializeField] Transform groundedChecker;
    [SerializeField] float groundedCheckRadius;
    [SerializeField] LayerMask foreGroundLayer;

    // Start is called before the first frame update
    void Start()
    {
        //Get and store a reference to the Rigidbody2D component so that we can access it.
        rigid2dObjectRef = GetComponent<Rigidbody2D>();

        grounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        groundCheckFunc();
        Jump();
    }

    void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float moveBy = x * speed;
        rigid2dObjectRef.velocity = new UnityEngine.Vector2(moveBy, rigid2dObjectRef.velocity.y);
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && grounded == true){ 
            rigid2dObjectRef.velocity = new UnityEngine.Vector2(rigid2dObjectRef.velocity.x, jumpForce);
            
        }
    }

    void groundCheckFunc()
    {
        Collider2D collider2D = Physics2D.OverlapCircle(groundedChecker.position, groundedCheckRadius, foreGroundLayer);

        if(collider2D != null)
        {
            grounded = true;
        }
        else
        {
            grounded = false;
        }


    }
}
