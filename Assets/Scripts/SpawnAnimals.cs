using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAnimals : MonoBehaviour
{
    public GameObject[] Animals;
    private int index;
    private Vector3 position;
    private int startSpawn = 3;
    private int spawnRepeat = 4;
    private int spawnCount;

    private void Start()
    {
        InvokeRepeating("Spawn", startSpawn, spawnRepeat);
    }
    void Spawn()
    {
        for (int i = 0; i < spawnCount; i++)
            position = new Vector3(UnityEngine.Random.Range(-112, -81), 0, UnityEngine.Random.Range(141, 117));
        index= UnityEngine.Random.Range (0, Animals.Length);
        Instantiate(Animals[index], position, Animals[index].transform.rotation);

        spawnCount++;


    }
}
