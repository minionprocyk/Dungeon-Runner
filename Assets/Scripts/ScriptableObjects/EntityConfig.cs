using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Config/EntityConfig")]
public class EntityConfig : ScriptableObject {

    [Header(header:"Entity Config")]
    public IntegerVariable EntityHealth;
    public IntegerVariable EntityLevel;
    public IntegerVariable EntityEnergy;
    public Image Icon;
}
