using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour
{
    public float speed = 3;
    public float jumpSpeed = 5;
    private Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.I))
        {
            Vector3 movement = new Vector3(0, 0, speed);
            rb.AddForce(movement * speed);
        }
        if (Input.GetKey(KeyCode.K))
        {
            Vector3 movement = new Vector3(0, 0, -speed);
            rb.AddForce(movement * speed);
        }
        if (Input.GetKey(KeyCode.J))
        {
            Vector3 movement = new Vector3(-speed, 0, 0);
            rb.AddForce(movement * speed);
        }
        if (Input.GetKey(KeyCode.L))
        {
            Vector3 movement = new Vector3(speed, 0, 0);
            rb.AddForce(movement * speed);
        }
        

    }
}
