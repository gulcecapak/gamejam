using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeManager : MonoBehaviour
{
     public GameObject upgradeImage;

    public void OnUpgradeButtonClick()
    {
        upgradeImage.SetActive(true);
    }

}