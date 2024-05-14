using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerWallMovement : MonoBehaviour
{
    private float speed = 2f;
    void Update()
    {
        Vector3 temp = transform.position;
        temp.z += speed * Time.deltaTime;
        transform.position = temp;
    }
}
