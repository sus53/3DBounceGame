using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumppadScript : MonoBehaviour
{
    public float speed = 750;
    private void OnCollisionEnter(Collision collision)
    {
        GameObject Player = collision.gameObject;
        Rigidbody rb = Player.GetComponent<Rigidbody>();
        rb.AddForce(Vector3.up * speed);
       
    }
}
