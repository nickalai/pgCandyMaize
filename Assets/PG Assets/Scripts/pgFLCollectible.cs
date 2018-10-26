/*
Name: Nick Lai
Student ID#: 2282417
Chapman email: lai137@mail.chapman.edu
Course Number and Section: Panther Games 10/26 Workshop

Contains the logic for the flashlight collectible
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pgFLCollectible : MonoBehaviour
{
    public pgUIManager ui;

    public GameObject FlashLightGO;
    public int rotationSpeed = 10;
    public float degreesPerSecond = 10.0f;
    public float amplitude = 0.1f;
    public float frequency = 0.5f;

    Vector3 posOffset = new Vector3();
    Vector3 tempPos = new Vector3();


    // Use this for initialization
    void Start()
    {
        ui = GameObject.FindGameObjectWithTag("GameManager").GetComponentInChildren<pgUIManager>();
        posOffset = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //spins the flashlight
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed, Space.World);
        //floats up and down with a Sin()
        tempPos = posOffset;
        tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;
        transform.position = tempPos;
    }

    //destroys the flashlight on the floor, activates flashlight in hand, and updates the message text
    void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
        FlashLightGO.SetActive(true);
        ui.messageText.text = "Enter the maze!";
    }
}
