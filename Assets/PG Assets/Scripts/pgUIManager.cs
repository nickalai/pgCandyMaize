/*
Name: Nick Lai
Student ID#: 2282417
Chapman email: lai137@mail.chapman.edu
Course Number and Section: Panther Games 10/26 Workshop

Acts as a container for text objects to be updated by other logic.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pgUIManager : MonoBehaviour
{
    public pgGameManager gm;

    public Text timerText;
    public Text collectibleText;
    public Text messageText;

	// Use this for initialization
	void Start ()
    {
        gm = GetComponentInParent<pgGameManager>();
        messageText.text = "Grab the flashlight!";
	}

    //updates the timer via the GameManager
    public void DrawTimerText()
    {
        timerText.text = gm.timeRemaining.ToString();
    }
}
