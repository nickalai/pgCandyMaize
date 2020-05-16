/*
Name: Nick Lai
Chapman email: lai137@mail.chapman.edu

Acts as a container for text objects to be updated by other logic.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pgUIManager : MonoBehaviour
{
    #region Variables
    public pgGameManager gm;

    public Text timerText;
    public Text collectibleText;
    public Text messageText;

    #endregion
    #region Methods
    // Use this for initialization
    void Start ()
    {
        gm = GetComponentInParent<pgGameManager>();
        messageText.text = "Grab the flashlight!";
	}

    // Updates the timer's text via the value from pgGameManager
    public void DrawTimerText()
    {
        timerText.text = gm.timeRemaining.ToString();
    }

    #endregion
}
