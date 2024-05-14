using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostpadScript : MonoBehaviour
{
    public float boostSpeed;
    private void OnCollisionEnter(Collision collision)
    {
        GameObject booster = collision.gameObject;
        Rigidbody rb = booster.GetComponent<Rigidbody>();
        rb.AddForce(Vector3.forward * boostSpeed);
    }
}
