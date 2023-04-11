using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropCollision : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (gameObject.tag == "IaCar")
            rb.mass = 1f;

            if (collision.gameObject.tag == "Player")
        {
            rb.AddForce(new Vector3(0, 10, 0), ForceMode.Impulse);
            
        }
       

    }
}