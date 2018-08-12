using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Player))]
public class PlayerController : MonoBehaviour {
    [SerializeField]
    private GameObject InventoryMenu;
    private Player player;
    private void Start()
    {
        player = GetComponent<Player>();
    }
    // Update is called once per frame
    void Update () {
	    	
        if(Input.GetButtonDown("Inventory"))
        {
            InventoryMenu.SetActive(!InventoryMenu.activeSelf);
        }
        else if (Input.GetButtonDown("Ability1"))
        {
            player.CastAbility(0);
        }
        else if (Input.GetButtonDown("Ability2"))
        {
            player.CastAbility(1);
        }

    }

}
