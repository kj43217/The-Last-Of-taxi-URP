using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int gameScore = 0;
    public Text moneyText;

    public int timeLeft = 80;
    public Text timeText;

    private void Start()
    {
        gameScore = 0;
        timeLeft = 5;

        StartCoroutine("LoseTime");
    }

    void Update()
    {
        if (timeLeft <= 0)
        {
            timeText.text = "TIMES UP!";
            StopGame();
        }
        else
        {
            timeText.text = "" + timeLeft;
        }

        //timeText.text = "  " + timeLeft;
 
        moneyText.text = "Total Money: " + gameScore;
       
        if (gameScore > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", gameScore);
        }
    }

    public void StopGame()
    {
        //timeText.text = "TIMES UP!";
        StopCoroutine("LoseTime");
        Invoke("SceneLoader", 3);
        //SceneLoader();
        //SceneManager.LoadScene(1);    
    }

    private void SceneLoader()
    {
        SceneManager.LoadScene(1);
    }

    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
        }
    }
}