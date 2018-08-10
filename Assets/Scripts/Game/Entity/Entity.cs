using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : MonoBehaviour{

    [SerializeField]
    protected EntityConfig EntityConfig;

    [Header(header:"Entity Runtime Values:")]
    [SerializeField]
    protected int Health;
    [SerializeField]
    protected int Level;
    [SerializeField]
    protected int Energy;

    protected void InitializeConfig()
    {
        Health = EntityConfig.EntityHealth.RuntimeValue;
        Level = EntityConfig.EntityLevel.RuntimeValue;
        Energy = EntityConfig.EntityEnergy.RuntimeValue;
    }
    public virtual void Damage(int value)
    {
        Health = Mathf.Max(0,Health-value);

        if(Health<=0)
        {
            Die();
        }
    }
    public abstract void Die();
}
