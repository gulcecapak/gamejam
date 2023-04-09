using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UiScript : MonoBehaviour
{
    private float healt;
    private TextMeshProUGUI health;
    [SerializeField] GameObject healx;

    private float academyhealth;
    private TextMeshProUGUI ahealth;
    [SerializeField] GameObject ahealx;

    private float academyfood;
    private TextMeshProUGUI afood;
    [SerializeField] GameObject afoodx;

    private float academywater;
    private TextMeshProUGUI awater;
    [SerializeField] GameObject awaterx;

    private float academylevel;
    private TextMeshProUGUI alevel;
    [SerializeField] GameObject alevelx;

    private float enemycount;
    private TextMeshProUGUI ecount;
    [SerializeField] GameObject ecountx;

    void Start()
    {
        health = healx.GetComponent<TextMeshProUGUI>();
        ahealth = ahealx.GetComponent<TextMeshProUGUI>();
        afood = afoodx.GetComponent<TextMeshProUGUI>();
        awater = awaterx.GetComponent<TextMeshProUGUI>();
        alevel = alevelx.GetComponent<TextMeshProUGUI>();
        ecount = ecountx.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        healt = Playermovement.Phealth;
        health.text =healt.ToString("0");

        academyhealth =academyscript.Ahealth;
        ahealth.text = academyhealth.ToString("0");

        academyfood = academyscript.academyfood;
        afood.text = academyfood.ToString("0");

        academywater = academyscript.academywater;
        awater.text = academywater.ToString("0");

        academylevel = SpawnerController.levelimiz;
        alevel.text = academylevel.ToString("0");

        enemycount = SpawnerController.EnemycOunt;
        ecount.text = enemycount.ToString("0");

        if (academyhealth<=30)
        {
            ahealth.color = Color.red;
        }
        else
        {
            ahealth.color = Color.white;
        }

        if (academyfood <= 30)
        {
            afood.color = Color.red;
        }
        else
        {
            afood.color = Color.white;
        }
        if (academywater <= 30)
        {
            awater.color = Color.red;
        }
        else
        {
            awater.color = Color.white;
        }
        if (healt <= 30)
        {
            health.color = Color.red;
        }
        else
        {
            health.color = Color.white;
        }
    }
}
