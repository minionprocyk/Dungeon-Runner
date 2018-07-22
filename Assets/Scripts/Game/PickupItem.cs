using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItem : MonoBehaviour {
    public PlayerInventory PlayerInventory;
	
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered PickupItem");
        if(other.gameObject.CompareTag("obtainable_item"))
        {
            Debug.Log("Added item to player inventory");
            //get the item and store it into the player inventory
            Item item = other.gameObject.GetComponentInParent<GameItem>().item;
            PlayerInventory.gameItems.Add(item);
        }
    }
}
