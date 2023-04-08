using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public float speed;
    private Animator anim;
    private bool facingr = true;
    public float cd = 3;
    private float AttacksPeed=1.5f;
    public float Range = 18f;

    [SerializeField] private GameObject tas;
    [SerializeField] private Transform tasatma;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void Update()
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
        cd = cd - AttacksPeed * Time.deltaTime;
        //attack

        if ((cd <= 0) && (distanceclosestenemy < Range))
        {
            Instantiate(tas, tasatma.position, Quaternion.identity);


            cd = 3f;
        }
    }
        void FixedUpdate()
        {


            Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);
            movement = Vector3.ClampMagnitude(movement, 1);
            if ((Input.GetAxis("Horizontal") != 0) || (Input.GetAxis("Vertical") != 0))
            {
                anim.SetTrigger("run");
            }


            if (Input.GetKey(KeyCode.A) && facingr)
            {
                Flip();
            }
            if (Input.GetKey(KeyCode.D) && !facingr)
            {
                Flip();
            }


            transform.position = transform.position + movement * Time.fixedDeltaTime * speed;
        }
        private void Flip()
        {
            facingr = !facingr;
            transform.Rotate(Vector3.up * 180);
        }
    }

