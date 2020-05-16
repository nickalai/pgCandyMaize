/*
Name: Nick Lai
Chapman email: lai137@mail.chapman.edu

Keeps track of candy corn collectibles and holds the logic.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pgCollectibleManager : MonoBehaviour
{
    #region Variables
    public pgUIManager ui;

    public int collectiblesRemaining;
    public GameObject regCC;
    public GameObject keyCC;

    public AudioSource source;
    public AudioClip collectNoise;

    #endregion
    #region Methods
    // Use this for initialization
    void Start()
    {
        // Checks the scene for the amount of collectibles remaining
        collectiblesRemaining = GameObject.FindGameObjectsWithTag("Collectible").Length;
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // Updates the UI to show how many collectibles remain in play
        ui.collectibleText.text = collectiblesRemaining.ToString();
        if (collectiblesRemaining < 1)
        {
            ui.messageText.text = "Find the exit!";
        }
    }

    // Contains logic for candy corn collection
    public void CollectCandy(GameObject candy)
    {
        Destroy(candy);
        source.PlayOneShot(collectNoise);
        collectiblesRemaining--;
        Invoke("ActivateKey", 1f);
    }

    // Changes the last candy corn into a key candy
    public void ActivateKey()
    {
        if (collectiblesRemaining == 1)
        {
            pgCollectible lastCandy = GameObject.FindGameObjectWithTag("Collectible").GetComponent<pgCollectible>();
            lastCandy.normalCorn.SetActive(false);
            lastCandy.keyCorn.SetActive(true);
        }
    }

    #endregion
}
