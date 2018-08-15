using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using System;
using System.Collections.Generic;

[RequireComponent(typeof(Camera))]
[RequireComponent(typeof(TargetTag))]
public abstract class Entity : MonoBehaviour{

    [SerializeField]
    protected EntityConfig EntityConfig;
    

    [Header(header:"Entity Runtime Values:")]
    public int CurrentHealth;

    public int MaxHealth;
    public int Level;
    public int Energy;
    //public float TargetingRange; //Range at which an entity can 'target' another entity. Used for targeting effects

    [Header(header:"Entity Runtime Attributes:")]
    public int Vitality;          //Health
    public int Stamina;           //Energy
    public float MoveSpeed;         //Speed modifier for character walk/run speed
    public float AttackSpeed;       //Casting and attack rate
    public float AttackPower;       //Overall attack power, affects all spells and actions
    public float SpellPower;        //Attack power for only magic
    public float MeleePower;        //Attack power for only melee
    public float RangedPower;       //Attack power for only physical ranged
    public float HealingPower;      //Attack power for only healing

    [SerializeField]
    private TargetTag Targets;
    [SerializeField]
    private Camera Eyes;
    [SerializeField]
    protected List<GameObject> EntitiesInRange;
    [SerializeField]
    protected List<GameObject> EntitiesInView;
    [SerializeField]
    protected GameObject CurrentTarget;
    protected GameObject LastTarget;
    [SerializeField]
    protected UnityEvent DeathEvent;

    private void Update()
    {
        EntitiesInRange = Targets.TargetsInRange;
        //calculate an area within the camera that are enemies in view
        Plane[] planes = GeometryUtility.CalculateFrustumPlanes(Eyes);
        foreach(GameObject entity in EntitiesInRange)
        {
            Bounds bounds = new Bounds(entity.transform.position, Vector3.one);
           // bounds.Encapsulate(entity.transform.position);

            bool isInBounds = GeometryUtility.TestPlanesAABB(planes, bounds);
            if (isInBounds)
            {
                if(EntitiesInView.Contains(entity)==false)
                {
                    EntitiesInView.Add(entity);
                }
            }
        }
        

        //remove any entities from the view if they're not in range
        foreach(GameObject entity in EntitiesInRange)
        {
            Bounds bounds = new Bounds(entity.transform.position, Vector3.one);
            bool isInBounds = GeometryUtility.TestPlanesAABB(planes, bounds);
            if(isInBounds == false)
            {
                EntitiesInView.Remove(entity);
            }
        }
    }
    protected void InitializeConfig()
    {
        

        MaxHealth = EntityConfig.EntityHealth;
        CurrentHealth = MaxHealth;
        Level = EntityConfig.EntityLevel;
        Energy = EntityConfig.EntityEnergy;
        Vitality = EntityConfig.EntityAttributes.Vitality;
        Stamina = EntityConfig.EntityAttributes.Stamina;
        MoveSpeed = EntityConfig.EntityAttributes.MoveSpeed;
        AttackSpeed = EntityConfig.EntityAttributes.AttackSpeed;
        AttackPower = EntityConfig.EntityAttributes.AttackPower;
        SpellPower = EntityConfig.EntityAttributes.SpellPower;
        MeleePower = EntityConfig.EntityAttributes.MeleePower;
        RangedPower = EntityConfig.EntityAttributes.RangedPower;
        HealingPower = EntityConfig.EntityAttributes.HealingPower;
    }
    public virtual void Damage(int value)
    {
        CurrentHealth = Mathf.Max(0, CurrentHealth - value);

        if(CurrentHealth <= 0)
        {
            Die();
        }
    }

    public virtual void LevelUp()
    {
        Level += 1;
    }
    public virtual void Die()
    {
        DeathEvent.Invoke();
    }
}
