using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disc_Control : MonoBehaviour
{
   public List<GameObject> DiscList;

    public int Score ;
    private int P_Score ;
    public List<int> Numbers = new List<int>();
    public float FFA; //Forward Facing Angle


   
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
            if (Numbers[n] == 0) DiscList[n].transform.rotation = Quaternion.Euler(100f,0,FFA);
            else if (Numbers[n] == 1) DiscList[n].transform.rotation = Quaternion.Euler(64f, 0, FFA);
            else if (Numbers[n] == 2) DiscList[n].transform.rotation = Quaternion.Euler(40f, 0, FFA);
            else if (Numbers[n] == 3) DiscList[n].transform.rotation = Quaternion.Euler(2.4f, 0, FFA);
            else if (Numbers[n] == 4) DiscList[n].transform.rotation = Quaternion.Euler(-31f, 0, FFA);
            else if (Numbers[n] == 5) DiscList[n].transform.rotation = Quaternion.Euler(-82, 0, FFA);
            else if (Numbers[n] == 6) DiscList[n].transform.rotation = Quaternion.Euler(-114, 0, FFA);
            else if (Numbers[n] == 7) DiscList[n].transform.rotation = Quaternion.Euler(-140, 0, FFA);
            else if (Numbers[n] == 8) DiscList[n].transform.rotation = Quaternion.Euler(-173, 0,FFA);
            else if (Numbers[n] == 9) DiscList[n].transform.rotation = Quaternion.Euler(-216, 0, FFA);
        }
    }
}
