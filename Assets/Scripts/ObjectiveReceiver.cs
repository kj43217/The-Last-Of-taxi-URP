using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveReceiver : MonoBehaviour
{
    public Passenger myPassenger;
    public ObjectiveSystem objectiveSystem;
    private void OnTriggerEnter(Collider col)
    {
        if (myPassenger.inCar)
            if (col.CompareTag("Car"))
        {
                GetComponent<BoxCollider>().enabled = false;
                GetComponent<MeshRenderer>().enabled = false;
                objectiveSystem.CompleteObjective(myPassenger);           
        }
    }
}
