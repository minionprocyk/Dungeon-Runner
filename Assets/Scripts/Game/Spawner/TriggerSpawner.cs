using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerSpawner : MonoBehaviour {

    [Range(1,100)]
    public float reloadTime;
    private float _reloadTime;
    public bool stop = false;
    public GameObject[] Enemies;
    public Transform spawnPoint;
    public TMPro.TextMeshPro text;

	// Use this for initialization
	void Start () {
        _reloadTime = reloadTime;        
    }
	void resetTime()
    {
        reloadTime = _reloadTime;
    }
    void Spawn()
    {
        foreach(GameObject go in Enemies)
        {
            Instantiate(go, spawnPoint.position, Quaternion.identity);
        }
    }

    //support updating text on a textmeshpro text script
    //TODO: open up text editing as a parameter
    void UpdateText()
    {
        if(text)
        {
            string currText = text.text;
            int indexOfColon = currText.IndexOf(':');
            string finalText = string.Concat(currText.Substring(0, indexOfColon + 2),
                Mathf.RoundToInt(reloadTime).ToString());
            text.SetText(finalText);
        }
    
    }
	// Update is called once per frame
	void Update () {
		if(stop==false)
        {
            if(reloadTime<=0)
            {
                resetTime();
               
                Spawn();
            }
            else
            {
                reloadTime -= Time.deltaTime;
            }
            UpdateText();
        }
	}
}
