using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disc_Control : MonoBehaviour
{
   public List<GameObject> DiscList;

    public int Score ;
    private int P_Score ;
    public List<int> Numbers = new List<int>();


   
    private void Update()
    {
         ReadScore();
    }



    void ReadScore()
    {
        int Value;
       if (P_Score != Score)
        {
            P_Score = Score;
            Debug.Log(P_Score);
            Debug.Log(Score);
            Numbers.Clear();
            while (Score > 0)
            {
                Value = Score % 10;
                Score /= 10;
                Numbers.Add(Value);
            }

            P_Score = Score;
            UpdateScore();
        }
    }


    void UpdateScore()
    {
        int n;

        for (n = 0; n < DiscList.Count; n++)
        {
            if (Numbers[n] == 0)
            {
                Debug.Log("rotation en x 100");
                DiscList[n].transform.Rotate(100, 0, 0);
            }
            else if (Numbers[n] == 1)
            {
                Debug.Log("rotation en x 64");
                DiscList[n].transform.Rotate(64, 0, 0);
            }
            else if (Numbers[n] == 2) DiscList[n].transform.Rotate(40, 0, 0);
            else if (Numbers[n] == 3) DiscList[n].transform.Rotate(2.4f, 0, 0);
            else if (Numbers[n] == 4) DiscList[n].transform.Rotate(-31, 0, 0);
            else if (Numbers[n] == 5) DiscList[n].transform.Rotate(-82, 0, 0);
            else if (Numbers[n] == 6) DiscList[n].transform.Rotate(-114, 0, 0);
            else if (Numbers[n] == 7) DiscList[n].transform.Rotate(-140, 0, 0);
            else if (Numbers[n] == 8) DiscList[n].transform.Rotate(-173, 0, 0);
            else if (Numbers[n] == 9) DiscList[n].transform.Rotate(-216, 0, 0);
        }
    }
}
