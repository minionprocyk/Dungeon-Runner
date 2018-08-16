using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Entity {

    [Header(header:"Enemy Runtime Values:")]
    [SerializeField]
    protected float AggroRadius;

    void Start () {
        InitializeConfig();
        if(base.EntityConfig.GetType() == typeof(EnemyConfig)) 
         {
            EnemyConfig EnemyConfig = (EnemyConfig)EntityConfig;
            /**
             * Enemies have a level offset that can be used to spawn
             * enemies with a minor level variance. (Think WoW, Diablo)
             * 
             * Level variance not yet implemented
             */
        }
        
    }

    //draw a wire sphere of this enemy's aggro range
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, AggroRadius);
    }
    public bool InAggroRange(Transform other)
    {
        if(other)
        {
            float distance = Vector3.Distance(other.position, this.transform.position);
            return InAggroRange(distance);
        }
        else
        {
            return false;
        }
    }
    public bool InAggroRange(float distance)
    {
        return AggroRadius <= distance;
    }
    
}
