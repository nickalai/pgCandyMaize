/*
Name: Nick Lai
Chapman email: lai137@mail.chapman.edu

Contains core gameplay logic
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pgGameManager : MonoBehaviour
{
    #region Variables
    public pgCollectibleManager cm;
    public pgUIManager ui;
    public pgStartMaze sm;

    public GameObject winScreen;
    public GameObject loseScreen;
    public int timeRemaining = 60;

    private AudioSource source;
    public AudioClip winSound;
    public AudioClip loseSound;

    #endregion
    #region Methods
    // Use this for initialization
    void Start ()
    {
        cm = GetComponentInChildren<pgCollectibleManager>();
        ui = GetComponentInChildren<pgUIManager>();
        source = GetComponent<AudioSource>();
	}

    // Starts the timer
    public void StartTimer()
    {
        InvokeRepeating("RunTimer", 1, 1);
    }

    // Contains logic for the timer. If time runs out, then a loss screen is shown
    void RunTimer()
    {
        ui.DrawTimerText();
        timeRemaining--;
        // Set as 2 due to a visual bug
        if(timeRemaining <= -2)
        {
            StopTimer();
            ShowLoseScreen();
        }
    }

    // Stops the timer
    public void StopTimer()
    {
        CancelInvoke();
    }

    // Displays the UI win screen and plays a victory sound effect
    public void ShowWinScreen()
    {
        winScreen.SetActive(true);
        source.PlayOneShot(winSound);  
    }

    // Displays the UI loss screen and plays a lose sound effect
    public void ShowLoseScreen()
    {
        loseScreen.SetActive(true);
        source.PlayOneShot(loseSound);
    }
    #endregion
}
