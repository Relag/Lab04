using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneTower : Tower
{
    public GameObject stonePrefab;

    protected override void AttackEnemy()
    {
        base.AttackEnemy();
        {
            base.AttackEnemy();
            GameObject stone = Instantiate(stonePrefab, towerPieceToAim.position, Quaternion.identity);
            stone.GetComponent<Stone>().enemyToFollow = targetEnemy;
            stone.GetComponent<Stone>().damage = attackPower;
        }
    }
}
