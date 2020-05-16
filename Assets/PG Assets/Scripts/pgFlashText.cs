/*
Name: Nick Lai
Chapman email: lai137@mail.chapman.edu

Contains the logic for flashing text on the screen. Used to flash the text for restarting the game.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pgFlashText : MonoBehaviour
{
    #region Variables
    public bool isOn = false;
    public GameObject textToFlash;

    #endregion
    #region Methods
    // Constantly instantiates "ToggleObject" method at a rate of once per second.
    void Start ()
    {
        InvokeRepeating("ToggleObject", 0.1f, 1f);
	}
	
    // Turns the object on and off
    void ToggleObject()
    {
        if (isOn)
        {
            textToFlash.SetActive(false);
            isOn = false;
        }
        else if (!isOn)
        {
            textToFlash.SetActive(true);
            isOn = true;
        }
    }

    #endregion
}
