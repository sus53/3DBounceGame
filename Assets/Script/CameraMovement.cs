using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    GameObject playerObj;
    Vector3 cameraOffset;
   
    public float x = 4.62f;
    public float y = 5.89f;
    public float z = -19.02f;
    void Start()
    {
        playerObj = GameObject.Find("Player");
        cameraOffset = new Vector3(x, y, z);
    }
    void Update()
    {
        transform.position = playerObj.transform.position + cameraOffset;
    }
}
