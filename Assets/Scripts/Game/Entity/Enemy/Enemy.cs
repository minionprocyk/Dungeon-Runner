using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Entity {

    [Header(header:"Enemy Runtime Values:")]
    [SerializeField]
    private float AggroRadius;



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
	
    
}
