/*
Name: Nick Lai
Student ID#: 2282417
Chapman email: lai137@mail.chapman.edu
Course Number and Section: Panther Games 10/26 Workshop

Quits the game when the escape key is hit
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pgQuitGame : MonoBehaviour
{
	void Update ()
    {
		if(Input.GetKey("escape"))
        {
            Application.Quit();
            Debug.Log("Quitting game..."); //editor use for making sure the esc key is registering
        }
	}
}
