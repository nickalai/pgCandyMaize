/*
Name: Nick Lai
Chapman email: lai137@mail.chapman.edu

This script is currently not in use in the project. If you would like to use it to be able to toggle the flashlight, simply add this script to the flashlight on
the player controller, then add the point light to the lightsource tab.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pgFlashlight : MonoBehaviour
{
    #region Variables
    public bool isOn; // Keeps track of whether the light is on or off
    public GameObject lightsource;

    #endregion
    #region Variables
    // Update is called once per frame
    void Update()
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

    #endregion
}
