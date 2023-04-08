using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Controller : MonoBehaviour
{
   private Transform HousesPos;
   private Transform EnemyPos;
   private Transform PlayerPos;
   public float speed;
   public float minDistance = 6f;
   public GameObject FirePoint;

    void Start()
    {
        HousesPos = GameObject.FindGameObjectWithTag("Houses").GetComponent<Transform>(); //house in trans. erisilecek
        EnemyPos = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Transform>(); //enemy in trans. erisilecek
        PlayerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>(); // player in trans. erisilecek
    }

    void Update()
    {
        float distance = Vector2.Distance(HousesPos.position, EnemyPos.position);

        if(distance > minDistance)
        {
         transform.position = Vector2.MoveTowards(transform.position, HousesPos.position, speed * Time.deltaTime);
        }
       
    }
}
