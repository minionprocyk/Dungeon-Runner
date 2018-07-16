using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Inventory/PlayerInventory")]
public class PlayerInventory : ScriptableObject {

    public List<Item> gameItems;

    private void OnEnable()
    {
        gameItems = new List<Item>();
    }
}
