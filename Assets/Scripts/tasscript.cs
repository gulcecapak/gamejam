using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tasscript : MonoBehaviour
{
    public float speed = 10;
    public static bool enemy = false;
    private GameObject[] Hero;
    public static bool poison;
    public static bool snail;
    void Start()
    {

        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        float distanceclosestenemy = Mathf.Infinity;
        enemyscript closestenemy = null;
        enemyscript[] allenemies = GameObject.FindObjectsOfType<enemyscript>();

        foreach (enemyscript currentenemy in allenemies)
        {
            float distancetoenemy = (currentenemy.transform.position - this.transform.position).sqrMagnitude;
            if (distancetoenemy < distanceclosestenemy)
            {
                distanceclosestenemy = distancetoenemy;
                closestenemy = currentenemy;


            }
        }

        transform.position = Vector2.MoveTowards(transform.position, closestenemy.transform.position, speed * Time.fixedDeltaTime);
        transform.Rotate(Vector2.right * speed * Time.fixedDeltaTime * 1f);
        

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Enemy")
        {
            Destroy(this.gameObject);
        }
    }
}
