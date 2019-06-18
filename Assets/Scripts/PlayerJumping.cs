using System.Collections;
using UnityEngine;

public class PlayerJumping : MonoBehaviour
{
    public float jumpForce = 10f;

    public Transform groundCheck;
    public float groundRadius = 0.2f;
    public bool grounded = false;
    public LayerMask whatIsGround;
    private Rigidbody2D rigidBody;

   

    void Start ()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        bool jump = Input.GetButtonDown("Jump");

        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);

        if (jump && grounded) GetComponent<Rigidbody2D>().AddForce(Vector3.up * jumpForce);
    }
}
