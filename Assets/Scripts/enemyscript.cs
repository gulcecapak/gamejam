using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyscript : MonoBehaviour
{
    public float speed;
   
    public float hEalth = 40f;
    public float enemydamage;

    float curTime = 0;
    float nextDamage = 2f;

    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(hEalth<=0)
        {
            Destroy(this.gameObject);
        }

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


     else   if ((Vector2.Distance(transform.position, closestenemy.transform.position) > 1.42f) &&( closestenemy.name == "Player"))
        {

            transform.position = Vector2.MoveTowards(transform.position, closestenemy.transform.position, speed * Time.deltaTime);

        }






    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="bullet")
        {
            hEalth = hEalth - Playermovement.Pdmage;
            Destroy(collision.gameObject);
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (curTime <= 0)
            {

                Playermovement.DamageAL(enemydamage);



                curTime = nextDamage;
            }
            
        

        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (curTime <= 0)
            {
                
               Playermovement.DamageAL(enemydamage);
                


                curTime = nextDamage;
            }
            else
            {

                curTime -= Time.deltaTime;
            }


        }
    }
}
