/*
Name: Nick Lai
Student ID#: 2282417
Chapman email: lai137@mail.chapman.edu
Course Number and Section: Panther Games 10/26 Workshop

Contains the logic for reloading the current scene
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pgReloadScene : MonoBehaviour
{
    //reloads the current scene when spacebar is pressed
	void Update ()
    {
		if(Input.GetKeyDown(KeyCode.Space))
        {
            LoadScene();
        }
	}

    //logic for finding the scene
    void LoadScene()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
}
