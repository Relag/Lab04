using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointManager : MonoBehaviour {

    public static WaypointManager Instance;

    public List<Path> Paths = new List<Path>();

	// Use this for initialization
	void Awake () {
        Instance = this;
	}

    public Vector3 GetSpawnPosition(int pathIndex)
    {
        return Paths[pathIndex].Waypoint[0].position;
    }
}

[System.Serializable]
public class Path
{
    public List<Transform> Waypoint = new List<Transform>();
}