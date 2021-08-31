using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject[] animalPrefabs;
    [SerializeField] float startDelay;
    [SerializeField] float spawnTime;

    float randomRangeX = 10f;

    private void Start()
    {
        //After startDelay duration Animals will spawn every spawnTime value
        InvokeRepeating("SpawnRandom", startDelay, spawnTime);
    }

    void SpawnRandom()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-randomRangeX, randomRangeX), 0, 18);
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
