using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Character/Ability/RaycastAbility")]
public class RaycastAbility : Ability
{
    public int Damage;
    public float Range;
    public float Force;

    public Color Color;
    private RaycastShootTriggerable rcShoot;

    public override void Initialize(GameObject obj)
    {
        rcShoot = obj.GetComponent<RaycastShootTriggerable>();
        rcShoot.Initialize();

        rcShoot.gunDamage = Damage;
        rcShoot.weaponRange = Range;
        rcShoot.hitForce = Force;
        rcShoot.laserLine.material = new Material(Shader.Find("Unlit/Color"));
        rcShoot.laserLine.material.color = Color;
    }

    public override void Trigger()
    {
        rcShoot.Fire();
    }
}
