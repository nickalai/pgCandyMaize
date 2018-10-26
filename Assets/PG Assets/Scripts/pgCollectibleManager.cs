/*
Name: Nick Lai
Student ID#: 2282417
Chapman email: lai137@mail.chapman.edu
Course Number and Section: Panther Games 10/26 Workshop

Keeps track of candy corn collectibles and holds the logic.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pgCollectibleManager : MonoBehaviour
{
    public pgUIManager ui;

    public int collectiblesRemaining;
    public GameObject regCC;
    public GameObject keyCC;

    public AudioSource source;
    public AudioClip collectNoise;
  

	// Use this for initialization
	void Start ()
    {
        //checks the scene for the amount of collectibles
        collectiblesRemaining = GameObject.FindGameObjectsWithTag("Collectible").Length;
        source = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        //updates the UI
        ui.collectibleText.text = collectiblesRemaining.ToString();
        if (collectiblesRemaining < 1)
        {
            ui.messageText.text = "Find the exit!";
        }
	}

    //logic for candy corn collection
    public void CollectCandy(GameObject candy)
    {
        Destroy(candy);
        source.PlayOneShot(collectNoise);
        collectiblesRemaining--;
        Invoke("ActivateKey", 1f);
    }

    //changes the last candy corn into a key candy
    public void ActivateKey()
    {
        if (collectiblesRemaining == 1)
        {
            pgCollectible lastCandy = GameObject.FindGameObjectWithTag("Collectible").GetComponent<pgCollectible>();
            lastCandy.normalCorn.SetActive(false);
            lastCandy.keyCorn.SetActive(true);
        }
    }
}
