using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Attributes")]
public class Attributes : ScriptableObject
{
    public int Vitality = 100;          //Health
    public int Stamina = 100;           //Energy
    public float MoveSpeed = 1.0f;         //Speed modifier for character walk/run speed
    public float AttackSpeed = 1.0f;       //Casting and attack rate
    public float AttackPower = 100;       //Overall attack power, affects all spells and actions
    public float SpellPower = 100;        //Attack power for only magic
    public float MeleePower = 100;        //Attack power for only melee
    public float RangedPower = 100;       //Attack power for only physical ranged
    public float HealingPower = 100;      //Attack power for only healing

    //TBD
    //public float SomethingElse;     
}
