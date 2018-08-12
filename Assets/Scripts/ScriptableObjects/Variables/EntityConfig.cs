using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Config/EntityConfig")]
public class EntityConfig : ScriptableObject {

    [Header(header:"Entity Config")]
    public int EntityHealth;
    public int EntityLevel;
    public int EntityEnergy;
    public Image Icon;
}
