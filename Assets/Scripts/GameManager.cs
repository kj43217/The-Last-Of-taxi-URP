using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [HideInInspector]
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

        if (timeLeft <= 0)
        {
            StopCoroutine("LoseTime");
            timeText.text = "Times Up!";

            SceneManager.LoadScene(0);
        }

        moneyText.text = "Total Money: " + gameScore;
       
        if (gameScore > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", gameScore);
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