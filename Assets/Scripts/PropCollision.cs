using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropCollision : MonoBehaviour
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
        if (gameObject.tag == "IaCar" && collision.gameObject.tag == "Player")
        {
            rb.mass = 1f;
            rb.AddForce(new Vector3(0, 10, 0), ForceMode.Impulse);
        }
    }
}