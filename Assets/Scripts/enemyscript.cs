using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyscript : MonoBehaviour
{
    public float speed;
    public GameObject Player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FindPlayerorHome();
    }

    void FindPlayerorHome()
    {
        float distanceclosestenemy = Mathf.Infinity;
        Finding closestenemy = null;
        Finding[] allenemies = GameObject.FindObjectsOfType<Finding>();

        foreach (Finding currentenemy in allenemies)
        {
            float distancetoenemy = (currentenemy.transform.position - this.transform.position).sqrMagnitude;
            if (distancetoenemy < distanceclosestenemy)
            {
                distanceclosestenemy = distancetoenemy;
                closestenemy = currentenemy;


            }
        }

        if ((Vector2.Distance(transform.position, closestenemy.transform.position) > 4)  && (closestenemy.name != "Player"))
        {
            
            transform.position = Vector2.MoveTowards(transform.position, closestenemy.transform.position, speed * Time.deltaTime);
           
        }


     else   if ((Vector2.Distance(transform.position, closestenemy.transform.position) > 1.35f) &&( closestenemy.name == "Player"))
        {

            transform.position = Vector2.MoveTowards(transform.position, closestenemy.transform.position, speed * Time.deltaTime);

        }






    }
}
