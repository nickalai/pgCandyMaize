/*
Name: Nick Lai
Chapman email: lai137@mail.chapman.edu

Contains the logic for reloading the current scene
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pgReloadScene : MonoBehaviour
{
    #region Methods
    // Reloads the current scene when spacebar is pressed
    void Update ()
    {
		if(Input.GetKeyDown(KeyCode.Space))
        {
            LoadScene();
        }
	}

    // Contains logic for finding the current scene
    void LoadScene()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }

    #endregion
}
