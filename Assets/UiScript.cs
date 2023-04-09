using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UiScript : MonoBehaviour
{
    
    private TextMeshProUGUI health;
    [SerializeField] GameObject healx;

    
    private TextMeshProUGUI ahealth;
    [SerializeField] GameObject ahealx;

    
    private TextMeshProUGUI afood;
    [SerializeField] GameObject afoodx;

    
    private TextMeshProUGUI awater;
    [SerializeField] GameObject awaterx;

    
    private TextMeshProUGUI alevel;
    [SerializeField] GameObject alevelx;

    private TextMeshProUGUI ecount;
    [SerializeField] GameObject ecountx;

    private TextMeshProUGUI ecoin;
    [SerializeField] GameObject ecoinx;

    void Start()
    {
        health = healx.GetComponent<TextMeshProUGUI>();
        ahealth = ahealx.GetComponent<TextMeshProUGUI>();
        afood = afoodx.GetComponent<TextMeshProUGUI>();
        awater = awaterx.GetComponent<TextMeshProUGUI>();
        alevel = alevelx.GetComponent<TextMeshProUGUI>();
        ecount = ecountx.GetComponent<TextMeshProUGUI>();
        ecoin = ecoinx.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
        health.text = Playermovement.Phealth.ToString("0");

        
        ahealth.text = academyscript.Ahealth.ToString("0");

        
        afood.text = academyscript.academyfood.ToString("0");

        
        awater.text = academyscript.academywater.ToString("0");

       
        alevel.text = SpawnerController.levelimiz.ToString("0");

       
        ecount.text = SpawnerController.EnemycOunt.ToString("0");

       
        ecoin.text = Playermovement.gold.ToString("0");

        if (academyscript.Ahealth <= 30)
        {
            ahealth.color = Color.red;
        }
        else
        {
            ahealth.color = Color.white;
        }

        if (academyscript.academyfood <= 30)
        {
            afood.color = Color.red;
        }
        else
        {
            afood.color = Color.white;
        }
        if (academyscript.academywater <= 30)
        {
            awater.color = Color.red;
        }
        else
        {
            awater.color = Color.white;
        }
        if (Playermovement.Phealth <= 30)
        {
            health.color = Color.red;
        }
        else
        {
            health.color = Color.white;
        }
    }

    public void AkademiHP()
    {
        if(Playermovement.gold-15 >=0)
        {
            academyscript.Ahealth += 25;
            Playermovement.gold -= 15;
        }
        
    }
    public void GoblinHP()
    {
        if (Playermovement.gold - 25 >= 0)
        {
            Playermovement.Phealth += 25;
            Playermovement.gold -= 25;
        }
    }

    public void Speed()
    {
            if (Playermovement.gold - 15 >= 0)
            {
                Playermovement.speed += 0.5f;
                Playermovement.gold -= 15;
            }

    }
    public void DmgArtis()
    {
                if (Playermovement.gold - 20 >= 0)
                {
                    Playermovement.Pdmage += 10;
                    Playermovement.gold -= 20;
                }
    }

    public void Yemekartis()
    {
                    if (Playermovement.gold - 10 >= 0)
                    {
                        academyscript.academyfood += 50;
                        Playermovement.gold -= 10;
                    }
    }
    public void SuArtis()
    {
                    if (Playermovement.gold - 10 >= 0)
                    {
                        academyscript.academywater += 50;
                        Playermovement.gold -= 10;
                    }
    }
}
