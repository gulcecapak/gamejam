using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Controller : MonoBehaviour
{
   private Transform PlayerPos;
   public float speed;

    void Start()
    {
        PlayerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>(); //player in transformuna erisilecek
    }

    
    void Update()
    {
        transform.position = Vector2.MoveTowards(
            transform.position,
            PlayerPos.position,
            speed * Time.deltaTime

        );
    }
}
