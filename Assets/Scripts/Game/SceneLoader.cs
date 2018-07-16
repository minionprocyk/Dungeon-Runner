using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DungeonLoader : MonoBehaviour {
    public Dungeon dungeon;
	
	public void LoadDungeon()
    {
        SceneManager.LoadScene(dungeon.SceneName);
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Loading new Dungeon: " + dungeon.SceneName);
        LoadDungeon();
    }
}
