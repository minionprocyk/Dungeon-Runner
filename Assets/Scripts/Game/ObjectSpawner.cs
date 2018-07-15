using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner: MonoBehaviour {
    public List<GameObject> spawnPoints;
    public GameObject prefab;

	// Use this for initialization
	void Start () {
	    foreach(GameObject point in spawnPoints)
        {
            Instantiate(prefab, point.transform);
        }	
	}
	
}
