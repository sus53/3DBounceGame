using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameoverScript : MonoBehaviour
{
    public GameObject UiObject;
    void Start()
    {
        UiObject.SetActive(false);
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter (Collider other)
    {
        if (other.tag == "Player")
        {
            UiObject.SetActive(true);
        }
    }

    
}
