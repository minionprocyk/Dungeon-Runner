using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Race Race;
    public RaceClass RaceClass;
    public IntegerVariable Health;              //Health is BaseHealth with modifiers applied
    public IntegerVariable Energy;              //Health is BaseEnergy with modifiers applied
    public PlayerInventory PlayerInventory;
    public IntegerVariable Level;
    public LongVariable Experience;
    public LongVariable ExpToNextLevel;
    public List<Ability> Abilities;
    

    
}