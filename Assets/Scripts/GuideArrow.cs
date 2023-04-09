using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuideArrow : MonoBehaviour
{
    ObjectiveSystem objectiveSystem;
    public Transform deliver1, deliver2, deliver3;
    //public GameObject passenger1, passenger2, passenger3;

    // Start is called before the first frame update
    void Awake()
    {
        deliver1 = GameObject.FindGameObjectWithTag("Deliver1").GetComponent<Transform>();
        /*deliver2 = GameObject.FindGameObjectWithTag("Deliver2").GetComponent<Transform>();
        deliver3 = GameObject.FindGameObjectWithTag("Deliver3").GetComponent<Transform>();*/

        objectiveSystem = GameObject.FindGameObjectWithTag("Passenger").GetComponentInChildren<ObjectiveSystem>();   
    }

    // Update is called once per frame
    void Update()
    {
        ArrowLook();
        
    }

    public void ArrowLook()
    {
        if (objectiveSystem.passenger1inCar == true)
        {
            transform.LookAt(deliver1);
        }
        /*if (objectiveSystem.passenger2)
        {
            transform.LookAt(deliver2);
        }
        if (objectiveSystem.passenger3)
        {
            transform.LookAt(deliver3);
        }*/
    }
}
