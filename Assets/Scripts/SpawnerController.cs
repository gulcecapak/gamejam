using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    public GameObject RealEnemyPrefab;
    public Transform[] SpawnPoints;

    public static int levelimiz;
    
    public float cd = 5f;

    private int guncelrakip;
    private int maxrakip;
   
    public static int EnemycOunt;

    void Start()
    {
        levelimiz = 1;
        guncelrakip = 0;
        EnemycOunt = guncelrakip;
        maxrakip=(levelimiz*3)+1;
      
    }

    private void Update()
    {
        cd = cd-(1f*Time.deltaTime);
        if((cd<=0)&& (guncelrakip!=maxrakip))
        {
            Spawnla();
        }

        if((guncelrakip==maxrakip) && (EnemycOunt==0))
        {
            LevelUP();
        }
       


    }

        private void Spawnla()
    {
        int randPos = Random.Range(0, SpawnPoints.Length);
        GameObject newEnemy = Instantiate(RealEnemyPrefab, SpawnPoints[randPos].position, Quaternion.identity);
        guncelrakip++;
        EnemycOunt++;
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
