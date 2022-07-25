using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject[] ufoPrefabs; // Array to store UFO ships

    public int ufoIndex;


    // Update is called once per frame
    void Update()
    {
        Instantiate(ufoPrefabs[ufoIndex], new Vector3(0,0,0), ufoPrefabs[ufoIndex].transform.rotation);
    }
}
