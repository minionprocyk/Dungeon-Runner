using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class Item : ScriptableObject {
    [Header(header:"Item Variables:")]
    public string Name;
    public string Description;
    public int ManaCost;
    public int HealthCost;
    public Sprite Icon;

}
