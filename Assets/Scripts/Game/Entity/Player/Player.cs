using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity {

    [Header(header:"Player Runtime Values:")]
    public long Experience;
    public long ExpToNextLevel;
    public PlayerInventory PlayerInventory;
    public List<Ability> Abilities;
   
    private void Start()
    {
        InitializeConfig();
        if (base.EntityConfig.GetType() == typeof(EnemyConfig))
        {
            PlayerConfig playerConfig = (PlayerConfig)EntityConfig;
            Experience = playerConfig.Experience.RuntimeValue;
            ExpToNextLevel = playerConfig.ExperienceToNextLevel.RuntimeValue;
            /**
             * Enemies have a level offset that can be used to spawn
             * enemies with a minor level variance. (Think WoW, Diablo)
             * 
             * Level variance not yet implemented
             */
            //Level = EnemyConfig.EntityLevel.RuntimeValue;
        }
    }
    public override void Die()
    {
        throw new System.NotImplementedException();
    }
    
}