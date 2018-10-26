/*
Name: Nick Lai
Student ID#: 2282417
Chapman email: lai137@mail.chapman.edu
Course Number and Section: Panther Games 10/26 Workshop

Contains the logic for the start gate of the maze
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pgStartMaze : MonoBehaviour
{
    public Animator anim;

    public pgGameManager gm;
    public pgUIManager ui;
    public pgFLCollectible fl;

    public GameObject spawnWall;
    public GameObject gate;

    public AudioSource source;
    public AudioClip gateOpening;

	// Use this for initialization
	void Start ()
    {
        anim = GetComponent<Animator>();
        source = GetComponent<AudioSource>();
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<pgGameManager>();
        ui = GameObject.FindGameObjectWithTag("GameManager").GetComponentInChildren<pgUIManager>();
        fl = GameObject.FindGameObjectWithTag("FLCollectible").GetComponent<pgFLCollectible>();
	}

    //upon entering the trigger, if the player has collected the flashlight, then the gate opens, plays a sound, updates the message text and starts the timer
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

    //removes the gate and adds a wall of corn upon exiting the trigger
    void OnTriggerExit()
    {
        if (fl.FlashLightGO.activeSelf == true)
        {
            spawnWall.SetActive(true);
            gate.SetActive(false);
        }
    }
}
