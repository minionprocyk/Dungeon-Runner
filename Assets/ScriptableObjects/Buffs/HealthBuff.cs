using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Buffs/Health Buff")]
public class HealthBuff : Buff
{
    public override void Apply(Entity entity)
    {
        entity.MaxHealth += Amount;
    }
}
