using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class academyscript : MonoBehaviour
{
    public float health;
    public static float Ahealth;
        void Start()
    {
        Ahealth = health;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Ahealth);
        if (Ahealth<=0)
        {
            SceneManager.LoadScene(0);
        }
    }

    public static void Damageal(float value)
    {
        Ahealth = Ahealth -( value/2);
    }
    
}
