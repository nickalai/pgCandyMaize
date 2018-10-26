/*
Name: Nick Lai
Student ID#: 2282417
Chapman email: lai137@mail.chapman.edu
Course Number and Section: Panther Games 10/26 Workshop

Contains core gameplay logic
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pgGameManager : MonoBehaviour
{
    public pgCollectibleManager cm;
    public pgUIManager ui;
    public pgStartMaze sm;

    public GameObject winScreen;
    public GameObject loseScreen;
    public int timeRemaining = 60;

    private AudioSource source;
    public AudioClip winSound;
    public AudioClip loseSound;

	// Use this for initialization
	void Start ()
    {
        cm = GetComponentInChildren<pgCollectibleManager>();
        ui = GetComponentInChildren<pgUIManager>();
        source = GetComponent<AudioSource>();
	}

    //starts the timer
    public void StartTimer()
    {
        InvokeRepeating("RunTimer", 1, 1);
    }

    //logic for the timer. if time runs out, then a loss screen is shown
    void RunTimer()
    {
        ui.DrawTimerText();
        timeRemaining--;
        //set as 2 due to a visual bug
        if(timeRemaining <= -2)
        {
            StopTimer();
            ShowLoseScreen();
        }
    }

    //stops the timer
    public void StopTimer()
    {
        CancelInvoke();
    }

    //shows UI win screen and plays a win noise
    public void ShowWinScreen()
    {
        winScreen.SetActive(true);
        source.PlayOneShot(winSound);  
    }

    //shows UI loss screen and plays a lose noise
    public void ShowLoseScreen()
    {
        loseScreen.SetActive(true);
        source.PlayOneShot(loseSound);
    }
}
