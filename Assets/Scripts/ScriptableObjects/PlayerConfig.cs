using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Config/PlayerConfig")]
public class PlayerConfig : EntityConfig {

    [Header(header:"PlayerConfig")]
    public LongVariable Experience;
    public LongVariable ExperienceToNextLevel;

}
