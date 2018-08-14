using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment : MonoBehaviour {

    [Header(header:"Required Fields:")]
    [SerializeField]
    private EquipmentConfig Config;

    [Header(header:"Equipment Runtime Values:")]
    [SerializeField]
    private List<Ability> AbilitySet;
    [SerializeField]
    private Attributes EquipmentAttributes;
    public EquipmentType Type;
    private void Start()
    {
        AbilitySet = Config.AbilitySet;
        EquipmentAttributes = Config.EquipmentAttributes;
        Type = Config.Type;
    }

    public Attributes GetAttributes()
    {
        return EquipmentAttributes;
    }
    public List<Ability> GetAbilities()
    {
        return AbilitySet;
    }
}
