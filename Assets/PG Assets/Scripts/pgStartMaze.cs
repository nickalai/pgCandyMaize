/*
Name: Nick Lai
Chapman email: lai137@mail.chapman.edu

Contains the logic for the start gate of the maze
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pgStartMaze : MonoBehaviour
{
    #region Variables
    public Animator anim;

    public pgGameManager gm;
    public pgUIManager ui;
    public pgFLCollectible fl;

    public GameObject spawnWall;
    public GameObject gate;

    public AudioSource source;
    public AudioClip gateOpening;

    #endregion
    #region Methods
    // Use this for initialization
    void Start ()
    {
        anim = GetComponent<Animator>();
        source = GetComponent<AudioSource>();
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<pgGameManager>();
        ui = GameObject.FindGameObjectWithTag("GameManager").GetComponentInChildren<pgUIManager>();
        fl = GameObject.FindGameObjectWithTag("FLCollectible").GetComponent<pgFLCollectible>();
	}

    // Opens the gate, plays a sound effect, and starts a timer if the player has collected the Flashlight object
    void OnTriggerEnter()
    {
        if(fl.FlashLightGO.activeSelf == true)
        { 
            anim.Play("opening");
            source.PlayOneShot(gateOpening);
            ui.messageText.text = "Collect candy corn!";
            gm.StartTimer();
        }
    }

    // Removes the gate and adds a wall of corn upon exiting the trigger
    void OnTriggerExit()
    {
        if (fl.FlashLightGO.activeSelf == true)
        {
            spawnWall.SetActive(true);
            gate.SetActive(false);
        }
    }

    #endregion
}
