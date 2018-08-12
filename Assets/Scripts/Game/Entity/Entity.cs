using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public abstract class Entity : MonoBehaviour{

    [SerializeField]
    protected EntityConfig EntityConfig;

    [Header(header:"Entity Runtime Values:")]
    [SerializeField]
    protected int CurrentHealth;

    [SerializeField]
    protected int MaxHealth;
    [SerializeField]
    protected int Level;
    [SerializeField]
    protected int Energy;

    [SerializeField]
    protected UnityEvent DeathEvent;
    protected void InitializeConfig()
    {
        MaxHealth = EntityConfig.EntityHealth;
        CurrentHealth = MaxHealth;
        Level = EntityConfig.EntityLevel;
        Energy = EntityConfig.EntityEnergy;
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
