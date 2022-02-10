using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    public float JumpForce;
    private Vector2 inputs;
    public float rootSpeed;
    public Transform JumpPoint;
    public LayerMask WhatIsGround;
    public float RadiusSphere;

    public bool isGrounded;





    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        inputs.x = Input.GetAxis("Horizontal") * speed;
        inputs.y = Input.GetAxis("Vertical") * speed;
        float y = rb.velocity.y;

        isGrounded = Physics.CheckSphere(JumpPoint.position, RadiusSphere, WhatIsGround);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.velocity = new Vector3(rb.velocity.x, JumpForce, rb.velocity.z);


        }








        Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        bool isWalking = (Mathf.Abs(inputs.x) + Mathf.Abs(inputs.y)) > 0f;
        if (isWalking)
        {
            rb.velocity = new Vector3(inputs.x, rb.velocity.y, inputs.y);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(direction), rootSpeed * Time.deltaTime);
        }




    }
}
