using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    [SerializeField]
    private GameObject InventoryMenu;
    	
	// Update is called once per frame
	void Update () {
	    	
        if(Input.GetButtonDown("Inventory"))
        {
            InventoryMenu.SetActive(!InventoryMenu.activeSelf);
        }
	}
}
