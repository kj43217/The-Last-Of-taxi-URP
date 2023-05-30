using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Passenger_look : MonoBehaviour
{

    public GameObject car;
    private GameObject passanger;



    void Update()
    {
        this.transform.LookAt(car.transform);
    }
}
