/*
Name: Nick Lai
Student ID#: 2282417
Chapman email: lai137@mail.chapman.edu
Course Number and Section: Panther Games 10/26 Workshop

This script is currently not in use in the project. If you would like to use it to be able to toggle the flashlight, simply add this script to the flashlight on
the player controller, then add the point light to the lightsource tab.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pgFlashlight : MonoBehaviour
{
    public bool isOn; //keeps track of whether the light is on or off
    public GameObject lightsource;
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            //turns off the light
            if (isOn)
            {
                isOn = false;
                lightsource.SetActive(false);
            }
            //turns on the light
            else
            {
                isOn = true;
                lightsource.SetActive(true);
            }
        }
    }
}
