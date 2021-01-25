using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class CubeSpawner : MonoBehaviour
{
    public GameObject[] cubePrefabs;
    [SerializeField] private Transform playerTransform;
    public float spawnZ = 0;
    public float spawnX = 0;
    public int spawnAmount = 70;

    private void Start()
    {
        SpawnCubes();
    }

    public void SpawnCubes()
    {
        for (int i = 0; i < spawnAmount; i++)
        {
            Instantiate(cubePrefabs[Random.Range(0, cubePrefabs.Length)], playerTransform.position + new Vector3(Random.Range(-spawnX, spawnX) + 0.001f, 0.015f, Random.Range(0, spawnZ) * 1.1f), Quaternion.identity);
        }
    }
}
