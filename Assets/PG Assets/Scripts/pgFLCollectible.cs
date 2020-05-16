/*
Name: Nick Lai
Chapman email: lai137@mail.chapman.edu

Contains the logic for the flashlight collectible
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pgFLCollectible : MonoBehaviour
{
    #region Variables
    public pgUIManager ui;

    public GameObject FlashLightGO;
    public int rotationSpeed = 10;
    public float degreesPerSecond = 10.0f;
    public float amplitude = 0.1f;
    public float frequency = 0.5f;

    Vector3 posOffset = new Vector3();
    Vector3 tempPos = new Vector3();

    #endregion
    #region Methods
    // Use this for initialization
    void Start()
    {
        ui = GameObject.FindGameObjectWithTag("GameManager").GetComponentInChildren<pgUIManager>();
        posOffset = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Spins the object
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed, Space.World);
        
        // Bobs the object up and down
        tempPos = posOffset;
        tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;
        transform.position = tempPos;
    }

    // Destroys the object when collected and activates the Flashlight in hand. 
    void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
        FlashLightGO.SetActive(true);
        ui.messageText.text = "Enter the maze!";
    }

    #endregion
}
