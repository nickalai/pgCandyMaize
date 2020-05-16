/*
Name: Nick Lai
Chapman email: lai137@mail.chapman.edu


Contains logic for the rotation and bobbing of the candy corn collectible
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pgCollectible : MonoBehaviour
{
    #region Variables
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

    #endregion
    #region Methods
    // Use this for initialization
    void Start()
    {
        posOffset = transform.position;
        cm = GameObject.FindGameObjectWithTag("CollectibleManager").GetComponent<pgCollectibleManager>();
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

    // Calls logic from pgCollectibleManager when trigger is entered
    void OnTriggerEnter(Collider other)
    {
        cm.CollectCandy(gameObject);
    }

    #endregion
}
