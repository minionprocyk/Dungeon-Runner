using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Config/EnemyConfig")]
public class EnemyConfig : EntityConfig {

    [Header(header: "EnemyConfig")]
    public IntegerVariable LevelOffset;
}
