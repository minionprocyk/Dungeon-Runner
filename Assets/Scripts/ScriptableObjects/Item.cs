using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Inventory/Item")]
public class Item : ScriptableObject {
    public string description;
    public int ManaCost;
    public int HealthCost;
    public Ability Castable;
    
}
