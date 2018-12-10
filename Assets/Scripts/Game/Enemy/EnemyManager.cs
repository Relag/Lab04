﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class EnemyManager : MonoBehaviour
{
    public static EnemyManager Instance;
    public List<Enemy> Enemies = new List<Enemy>();

    private void Awake()
    {
        Instance = this;
    }

    public void RegisterEnemy(Enemy enemy)
    {
        Enemies.Add(enemy);
        UIManager.Instance.CreateHealthBarForEnemy(enemy);
    }

    public void UnRegisterEnemy(Enemy enemy)
    {
        Enemies.Remove(enemy);
    }

    public List<Enemy> GetEnemiesInRange(Vector3 position, float range)
    {
        return Enemies.Where(enemy => Vector3.Distance(position, enemy.transform.position) <= range).ToList();
    }

    public void DestroyAllEnemies()
    {
        foreach (Enemy enemy in Enemies)
        {
            Destroy(enemy.gameObject);
        }
        Enemies.Clear();
    }
}
