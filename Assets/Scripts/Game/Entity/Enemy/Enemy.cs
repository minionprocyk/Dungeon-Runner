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
            //Level = EnemyConfig.EntityLevel.RuntimeValue;
            Debug.Log("Level Offset: " + EnemyConfig.LevelOffset.RuntimeValue);
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
        float distance = Vector3.Distance(other.position, this.transform.position);
        return InAggroRange(distance);
    }
    public bool InAggroRange(float distance)
    {
        return AggroRadius <= distance;
    }
    
}
