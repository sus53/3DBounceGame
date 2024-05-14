using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 2;
    private Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 movement = new Vector3(0, 0, speed);
            rb.AddForce(movement * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 movement = new Vector3(0, 0, -speed);
            rb.AddForce(movement * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Vector3 movement = new Vector3(-speed, 0, 0);
            rb.AddForce(movement * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 movement = new Vector3(speed, 0, 0);
            rb.AddForce(movement * speed);
        }
    }
}
