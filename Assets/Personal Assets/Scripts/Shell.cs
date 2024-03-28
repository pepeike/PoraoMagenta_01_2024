using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour
{
    private float force = 5f;
    private float lifespan = 3f;
    public Rigidbody rb;

    void Start()
    {
        rb.AddForce(transform.forward * force, ForceMode.Impulse);
    }

    
}
