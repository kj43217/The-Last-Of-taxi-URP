using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveReceiver : MonoBehaviour
{
    public int objectiveId;

    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Car"))
        {
             ObjectiveSystem.instance.CompleteObjective(objectiveId);           
        }
    }
}
