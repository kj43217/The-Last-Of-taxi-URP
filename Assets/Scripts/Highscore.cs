using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Highscore : MonoBehaviour
{
    public Text HStext;
    // Start is called before the first frame update
    void Start()
    {
        HStext.text = "Highscore: " + PlayerPrefs.GetInt("HighScore");
    }

    void StartButton()
    {
        //SceneManager.LoadScene("TestCar");
    }
}
