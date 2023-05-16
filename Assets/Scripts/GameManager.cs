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
        timeLeft = 80;

        StartCoroutine("LoseTime");
    }

    void Update()
    {
        timeText.text = "Time Left: " + timeLeft;      

        moneyText.text = "Total Money: " + gameScore;
       
        if (gameScore > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", gameScore);
        }

        StopGame();
    }

    public void StopGame()
    {

        if (timeLeft <= 0 || Input.GetKeyDown(KeyCode.Escape))
        {
            StopCoroutine("LoseTime");
            timeText.text = "Times Up!";

            SceneManager.LoadScene(1);
        }       
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