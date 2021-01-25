using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSetter : MonoBehaviour
{
    public GameObject floorOnRunning;
    public GameObject floorForward;
    private CubeSpawner cubeSpawner;

    private void Start()
    {
        cubeSpawner = FindObjectOfType<CubeSpawner>();
    }

    void Update()
    {
        SwipeTwoGroundsForward();
    }

    void SwipeTwoGroundsForward()
    {
        if (transform.position.z > floorOnRunning.transform.position.z + 50)
        {
            
            var position = floorOnRunning.transform.position;
            position = new Vector3(position.x, position.y, floorForward.transform.position.z + 45.31f);
            floorOnRunning.transform.position = position;

            GameObject temp = floorOnRunning;
            floorOnRunning = floorForward;
            floorForward = temp;
            
            cubeSpawner.SpawnCubes();
        }
    }
}
