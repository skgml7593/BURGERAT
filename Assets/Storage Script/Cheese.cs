using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheese : MonoBehaviour
{
    Rigidbody rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)

    {
        if (collision.collider.CompareTag("Trap"))
        {
           
            rb.isKinematic = true;

        }

        else
        {
            rb.isKinematic = false;
        }
    }
}
