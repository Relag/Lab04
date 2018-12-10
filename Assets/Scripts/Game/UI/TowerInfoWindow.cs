﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TowerInfoWindow : MonoBehaviour {

    public Tower tower;
    public Text txtInfo;
    public Text txtUpgradeCost;

    private int upgradePrice;

    private GameObject btnUpgrade;

    void Awake()
    {
        btnUpgrade = txtUpgradeCost.transform.parent.gameObject;
    }

    private void OnEnable()
    {
        UpdateInfo();
    }

    private void UpdateInfo()
    {
        upgradePrice = Mathf.CeilToInt(TowerManager.Instance.GetTowerPrice(tower.type) * 1.5f * tower.towerLevel);

        txtInfo.text = tower.type + " Tower LV " + tower.towerLevel;

        if (tower.towerLevel < 3)
        {
            btnUpgrade.SetActive(true);
            txtUpgradeCost.text = "Upgrade/n" + upgradePrice + " Gold";
        }
        else
        {
            btnUpgrade.SetActive(false);
        }
    }

    public void UpgradeTower()
    {
        if (GameManager.Instance.gold >= upgradePrice)
        {
            GameManager.Instance.gold -= upgradePrice;
            tower.LevelUp();
            gameObject.SetActive(false);
        }
    }
}
