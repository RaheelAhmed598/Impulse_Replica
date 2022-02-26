using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //spwan point where the enemy spawn
    public List<GameObject> spawnPoints;
    public GameObject spawnObjects;

    // enemy spawn 
    private void Start()
    {
        InvokeRepeating("SpawnEnemies", 0.2f, 3f);
    }
    private void SpawnEnemies()
    {
        var index = Random.Range(0, spawnPoints.Count);
        Instantiate(spawnObjects, spawnPoints[index].transform.position, Quaternion.identity);
    }
}
