/*
Name: Nick Lai
Chapman email: lai137@mail.chapman.edu

Contains the logic for the winning gate
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pgWinZone : MonoBehaviour
{
    #region Variables
    public Animator anim;

    public pgGameManager gm;
    public pgCollectibleManager cm;
    public pgUIManager ui;

    public AudioSource source;
    public AudioClip gateOpening;

    #endregion
    #region Methods
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        source = GetComponent<AudioSource>();
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<pgGameManager>();
        ui = GameObject.FindGameObjectWithTag("GameManager").GetComponentInChildren<pgUIManager>();
        cm = GameObject.FindGameObjectWithTag("GameManager").GetComponentInChildren<pgCollectibleManager>();
    }

    /* When entering the trigger, checks for collection of all candy corn. If all is collected, changes the message text, stops the timer, opens the final gate,
       plays a noise, and shows the win screen when the animation completes. If all candy corn is not collected, the gate will not open and the message text will
       prompt the player to collect more candy corn. 
    */
    void OnTriggerEnter(Collider other)
    {
        if(cm.collectiblesRemaining < 1)
        {
            gm.StopTimer();
            anim.Play("opening");
            source.PlayOneShot(gateOpening);
            Invoke("DelayWin", 2.5f);
        }
        
        else
        {
            ui.messageText.text = "More candy corn...";
        }
    }

    // Makes a call to pgGameManager to show the ending win screen.
    void DelayWin()
    {
        gm.ShowWinScreen();
    }

    // Re-updates the text once the trigger is exited
    void OnTriggerExit(Collider other)
    {
        ui.messageText.text = "Collect candy corn!";
    }

    #endregion
}
