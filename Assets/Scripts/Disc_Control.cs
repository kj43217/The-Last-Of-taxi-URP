using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disc_Control : MonoBehaviour
{
    GameObject Disc_1;
    GameObject Disc_2;
    GameObject Disc_3;
    GameObject Disc_4;
    GameObject Disc_5;
    GameObject Disc_6;
    GameObject Disc_7;

     int Score = 1234;
    public List<int> Numbers = new List<int>();
    bool Did_Loop;


    private void Update()
    {
        ReadScore();
    }



    void ReadScore()
    {
        Debug.Log("hola");
      

        int Value;
        //if (Did_Loop == false)
       // {
            while (Score > 0)
            {
                Debug.Log("hola");
                Value = Score % 10;
                Score /= 10;
                Numbers.Add(Value);

              

            }

            //Did_Loop = true;
        //}
      

       

    }
}
