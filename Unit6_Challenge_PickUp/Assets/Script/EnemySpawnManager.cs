using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject[] ufoPrefabs; // Array to store UFO ships
    private float spawnRangeX = 50f;

    private float spawnPOsZ = 30f;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        { 
        
        Vector3 spawnPOs = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),0,spawnPOsZ);
        int ufoIndex = Random.Range(0, ufoPrefabs.Length); // Pick a random UFO

        Instantiate(ufoPrefabs[ufoIndex], spawnPOs, ufoPrefabs[ufoIndex].transform.rotation); // Spawns an indexed UFO in array 

    }
    }
}
