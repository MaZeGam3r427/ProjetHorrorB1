using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClimbingUp : MonoBehaviour
{

    private bool touchingCollider = false;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (touchingCollider)
            {
                Debug.Log("Lol");
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            touchingCollider = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            touchingCollider = false;
        }
    }
}
