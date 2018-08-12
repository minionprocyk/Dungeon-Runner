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

        rcShoot.GunDamage = Damage;
        rcShoot.WeaponRange = Range;
        rcShoot.HitForce = Force;
        rcShoot.LaserLine.material = new Material(Shader.Find("Unlit/Color"));
        rcShoot.LaserLine.material.color = Color;
    }

    public override void Trigger()
    {
        rcShoot.Trigger(this);

        //create a particle effect from the player's position
        GameObject fromObject = PlayerManager.instance.player;
        Instantiate(AbilityEffect, fromObject.transform.position, fromObject.transform.rotation);

    }
}
