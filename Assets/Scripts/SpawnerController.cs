using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    public GameObject RealEnemyPrefab;
    public Transform[] SpawnPoints;

    private int levelimiz;
    public float cd = 5f;

    private int guncelrakip;
    private int maxrakip;
   

    void Start()
    {
        levelimiz = 1;
        guncelrakip = 0;
        maxrakip=(levelimiz*3)+1;
      
    }

    private void Update()
    {
        cd = cd-(1f*Time.deltaTime);
        if((cd<=0)&& (guncelrakip!=maxrakip))
        {
            Spawnla();
        }

        if(guncelrakip==maxrakip)
        {
            LevelUP();
        }
       


    }

        private void Spawnla()
    {
        int randPos = Random.Range(0, SpawnPoints.Length);
        GameObject newEnemy = Instantiate(RealEnemyPrefab, SpawnPoints[randPos].position, Quaternion.identity);
        guncelrakip++;
        cd = 1;
    }
         private void LevelUP()
    {
        cd = 20;
        levelimiz++;
        maxrakip = (levelimiz * 3) + 1;
        guncelrakip = 0;
    }



}
