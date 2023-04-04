using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuideArrow : MonoBehaviour
{
    ObjectiveSystem objectiveSystem;
    public Transform deliver1, deliver2, deliver3;

    // Start is called before the first frame update
    void Start()
    {
        deliver1 = GameObject.FindGameObjectWithTag("Deliver").GetComponent<Transform>();
        deliver2 = GameObject.FindGameObjectWithTag("Deliver").GetComponent<Transform>();
        deliver3 = GameObject.FindGameObjectWithTag("Deliver").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    public void ArrowLook()
    {
        if (objectiveSystem.passenger1)
        {
            transform.LookAt(deliver1);
        }
        if (objectiveSystem.passenger2)
        {
            transform.LookAt(deliver2);
        }
        if (objectiveSystem.passenger3)
        {
            transform.LookAt(deliver3);
        }
    }
}
