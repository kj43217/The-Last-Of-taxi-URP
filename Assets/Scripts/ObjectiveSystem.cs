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

    GuideArrow guideArrow;

    private void Awake()
    {
        instance = this;
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
                Destroy(GameObject.FindWithTag("Deliver"));
                passenger2.gameObject.SetActive(true);
                Debug.Log(score.gameScore);
                

            }
            if (_id == 2)
            {
                passenger2.gameObject.SetActive(false);
                Destroy(GameObject.FindWithTag("Deliver"));
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

    private void OnTriggerExit(Collider col)
    {
        if (col.CompareTag("Car"))
        {
            playerIsHere = false;
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
        }
    }
}
