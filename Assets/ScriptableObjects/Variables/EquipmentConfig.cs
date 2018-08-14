using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Character/Equipment/Config")]
public class EquipmentConfig : ScriptableObject {
    public List<Ability> AbilitySet;
    public Attributes EquipmentAttributes;
    public EquipmentType Type;
}
