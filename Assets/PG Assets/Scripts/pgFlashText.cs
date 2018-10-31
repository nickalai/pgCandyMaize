/*
Name: Nick Lai
Student ID#: 2282417
Chapman email: lai137@mail.chapman.edu
Course Number and Section: Panther Games 10/26 Workshop

Contains the logic for flashing text on the screen. Used to flash the text for restarting the game.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pgFlashText : MonoBehaviour
{
    public bool isOn = false;
    public GameObject textToFlash;

	//Constantly instantiates "ToggleObject" method.
	void Start ()
    {
        InvokeRepeating("ToggleObject", 0.1f, 1f);
	}
	
    //turns the object on and off
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
}
