using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class academyscript : MonoBehaviour
{
    public float health;
    public static float Ahealth;

    public static float academyfood;
    public static float academywater;

    private float foodspeed = 1;
    private float waterspeed = 1;
        void Start()
    {
        academywater = 100;
        academyfood = 100;
        Ahealth = health;
    }

    // Update is called once per frame
    void Update()
    {
        academyfood -= academyfood * 0.01f * foodspeed * Time.deltaTime ;
        academywater -= academywater * 0.02f*waterspeed*Time.deltaTime;

        if(academywater<=0)
        {
            foodspeed = 2;
        }
        else if(academywater>0)
        {
            foodspeed = 1;
        }

        if(academyfood<=0)
        {
            waterspeed = 2;
        }
        else if (academyfood>0)
        {
            waterspeed = 1;
        }

        if((academyfood<=0) && (academywater<=0)  )
                {
            Ahealth = Ahealth -( Time.deltaTime * 0.1f);
        }
        

        Debug.Log(Ahealth);
        if ((Ahealth<=0))
        {
            SceneManager.LoadScene(0);
        }
    }

    public static void Damageal(float value)
    {
        
        Ahealth = Ahealth-value;
    }
    
}
