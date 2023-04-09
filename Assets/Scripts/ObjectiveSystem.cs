using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveSystem : MonoBehaviour
{
    public static ObjectiveSystem instance;

    public List<Objectives> objectives = new List<Objectives>();

    Objectives activeObjective;
    public GameManager score;

    bool playerIsHere;

    public GameObject passenger1, passenger2, passenger3;
    public GameObject enableTargetObject;
    public bool passenger1inCar, passenger2inCar, passenger3inCar;

    public GameObject guideArrow;

    private void Awake()
    {
        instance = this;
        //guideArrow = GameObject.FindGameObjectWithTag("GuideArrow").GetComponent<GuideArrow>();
    }

    private void Update()
    {
        StartCoroutine(WaitForPickup());
    }

    void AddObjective()
    {
        if (activeObjective == null)
        {
            Debug.Log("Route Started");
            activeObjective = objectives[Random.Range(0, objectives.Count)];
        }
    }

    public int ReadActiveObjective()
    {
        return activeObjective.id;
    }

    public void CompleteObjective(int _id)
    {
        if (activeObjective == null)
        {
            return;
        }
        if (activeObjective.id == _id)
        {
            //Objective Complete
            Debug.Log("Objective number" + activeObjective.id + " is completed");

            //Give Reward
            score.gameScore = activeObjective.timeReward;

            
            if(_id == 1)
            {
                passenger1.gameObject.SetActive(false);
                Destroy(GameObject.FindWithTag("Deliver1"));
                passenger2.gameObject.SetActive(true);
                Debug.Log(score.gameScore);
                

            }
            if (_id == 2)
            {
                passenger2.gameObject.SetActive(false);
                Destroy(GameObject.FindWithTag("Deliver2"));
                passenger3.gameObject.SetActive(true);
                Debug.Log(score.gameScore);
            }//activeObjective = null;
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Car"))
        {
            playerIsHere = true;
            Debug.Log("Picking up passenger");
        }
    }

    IEnumerator WaitForPickup()
    {               
        if (playerIsHere)
        {
            yield return new WaitForSeconds(2.5f); 
            enableTargetObject.GetComponent<MeshRenderer>().enabled = false;
            AddObjective();
            Debug.Log("Picked Up Passenger!!");

            if (passenger1 == true)
            {
                passenger1inCar = true;
                guideArrow.gameObject.SetActive(true);
            }
            /*if (passenger2 == true)
            {
                passenger2inCar = true;
                guideArrow.gameObject.SetActive(true);
            }
            if (passenger3 == true)
            {
                passenger3inCar = true;
                guideArrow.gameObject.SetActive(true);
            }*/
        }
    }
}
