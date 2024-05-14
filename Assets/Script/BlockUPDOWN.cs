using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockUPDOWN : MonoBehaviour
{
    public Transform block;
    public Vector3 closedPosition = new Vector3(-2, 0, 0);
    public Vector3 openedPosition = new Vector3(-2, 5, 0);
    public float openSpeed = 0.5f;
    private bool open = false;


    void Update()
    {
        if (open == true)
        {
            block.position = Vector3.Lerp(block.position, openedPosition, Time.deltaTime * openSpeed);
        }
        else
        {
            block.position = Vector3.Lerp(block.position, closedPosition, Time.deltaTime * openSpeed);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if ((other.tag == "Player") || (other.tag == "Player2"))
        {
            OpenBlock();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            CloseBlock();
        }
    }
    public void OpenBlock()
    {
        open = true;
    }
    public void CloseBlock()
    {
        open = false;
    }
}
