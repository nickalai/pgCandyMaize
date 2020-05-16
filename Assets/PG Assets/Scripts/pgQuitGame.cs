/*
Name: Nick Lai
Chapman email: lai137@mail.chapman.edu


Quits the game when the escape key is hit
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pgQuitGame : MonoBehaviour
{
    #region Methods
    void Update ()
    {
		if(Input.GetKey("escape"))
        {
            Application.Quit();
            Debug.Log("Quitting game..."); // Editor use for showing that the game would have been exited
        }
	}

    #endregion
}
