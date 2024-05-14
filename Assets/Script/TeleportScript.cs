using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : MonoBehaviour
{
    public float x = -0.3f;
    public float y = 54f;
    public float z = 103f;
    private void OnCollisionEnter(Collision collision)
    {
        GameObject teleport = collision.gameObject;
        teleport.transform.position = new Vector3(x, y, z);
    }
}
