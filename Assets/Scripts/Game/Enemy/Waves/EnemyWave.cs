using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class EnemyWave
{ 
    public int pathIndex;
    public float startSpawnTimeInSeconds;
    public float timeBetweenSpawnsInSeconds = 1f;
    public List<GameObject> listOfEnemies = new List<GameObject>();

}
