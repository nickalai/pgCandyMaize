/*
Name: Nick Lai
Student ID#: 2282417
Chapman email: lai137@mail.chapman.edu
Course Number and Section: Panther Games 10/26 Workshop

Contains logic for the rotation and bobbing of the candy corn collectible
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pgCollectible : MonoBehaviour
{
    public pgCollectibleManager cm;
    public pgUIManager ui;

    public GameObject normalCorn;
    public GameObject keyCorn;
    public int rotationSpeed = 50;
    public float degreesPerSecond = 10.0f;
    public float amplitude = 0.1f;
    public float frequency = 0.5f;

    Vector3 posOffset = new Vector3();
    Vector3 tempPos = new Vector3();

    // Use this for initialization
    void Start()
    {
        posOffset = transform.position;
        cm = GameObject.FindGameObjectWithTag("CollectibleManager").GetComponent<pgCollectibleManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //spins the candy corn
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed, Space.World);
        //floats up and down with a Sin()
        tempPos = posOffset;
        tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;
        transform.position = tempPos;
    }

    //calls logic from pgCollectibleManager
    void OnTriggerEnter(Collider other)
    {
        cm.CollectCandy(gameObject);
    }
}
