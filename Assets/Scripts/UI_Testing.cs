using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;
using CodeMonkey;

public class UI_Testing : MonoBehaviour
{

    public Highscore highscore;

    private void Awake()
    {
        highscore.highscoreTableBefore.SetActive(true);
        highscore.highscoreTableAfter.SetActive(false);
    }

    private void Start()
    {
        transform.Find("SubmitScoreButton").GetComponent<Button_UI>().ClickFunc = () =>
        {
            UI_Blocker.Show_Static();

            UI_InputWindow.Show_Static("Score", PlayerPrefs.GetInt("HighScore"), () =>
            {
                // Clicked Cancel
                UI_Blocker.Hide_Static();
            }, (int score) =>
            {
                // Clicked Ok
                UI_InputWindow.Show_Static("Player Name", "", "ABCDEFGHIJKLMNÑOPQRSTUVXYWZ", 3, () =>
                {
                    // Cancel
                    UI_Blocker.Hide_Static();
                }, (string nameText) =>
                {
                    // Ok
                    UI_Blocker.Hide_Static();
                    highscore.highscoreTableBefore.GetComponent<Highscore>().AddHighscoreEntry(score, nameText);
                    highscore.highscoreTableBefore.SetActive(false);
                    highscore.highscoreTableAfter.SetActive(true);
                });
            });
        };

    }
}