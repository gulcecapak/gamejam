using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    public GameObject RealEnemyPrefab;
    public Transform[] SpawnPoints;
    public float interval;

    void Start()
    {
        InvokeRepeating("Spawn", 0.5f, interval);
    }

    private void Spawn()
    {
        int randPos = Random.Range(0, SpawnPoints.Length);
        GameObject newEnemy = Instantiate(RealEnemyPrefab, SpawnPoints[randPos].position, Quaternion.identity);
    }
}
