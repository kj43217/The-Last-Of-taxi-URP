using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Next Route", menuName = "RouteSystem")]

public class Objectives : ScriptableObject
{
    public int timeReward;
    public int id;
    public GameObject routeGoal;

}
