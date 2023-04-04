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

    private void Start()
    {
        gameScore = 0;
    }

    void Update()
    {
        moneyText.text = "Total Money: " + gameScore;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("esc pressed");
            if (gameScore > PlayerPrefs.GetInt("HighScore"))
            {
                PlayerPrefs.SetInt("HighScore", gameScore);
            }
            SceneManager.LoadScene(1);

        }
    }
}