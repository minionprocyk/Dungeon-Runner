using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity {

    [Header(header:"Player Runtime Values:")]
    public long Experience;
    public long ExpToNextLevel;
    public PlayerInventory PlayerInventory;
    [SerializeField]
    private List<Ability> SpellBook;
    [SerializeField]
    private Equipment[] EquipmentPieces = new Equipment[8];

    void Start()
    {
        InitializeConfig();
        GetComponent<CharacterController>().isTrigger = false;
        if (base.EntityConfig.GetType() == typeof(PlayerConfig))
        {
            PlayerConfig playerConfig = (PlayerConfig)EntityConfig;
            Experience = playerConfig.Experience;
            ExpToNextLevel = playerConfig.ExperienceToNextLevel;
            OnEquip(); //should update stats/spells based on current equipment
            /**
             * Enemies have a level offset that can be used to spawn
             * enemies with a minor level variance. (Think WoW, Diablo)
             * 
             * Level variance not yet implemented
             */
            //Level = EnemyConfig.EntityLevel.RuntimeValue;
        }
    }

    private void AddSpells(List<Ability> abilities)
    {
        SpellBook.AddRange(abilities);

    }
    private void AddAttributes(Attributes attributes)
    {
        Vitality += attributes.Vitality;
        Stamina += attributes.Stamina;
        MoveSpeed += attributes.MoveSpeed;
        AttackSpeed += attributes.AttackSpeed;
        AttackPower += attributes.AttackPower;
        SpellPower += attributes.SpellPower;
        MeleePower += attributes.MeleePower;
        RangedPower += attributes.RangedPower;
        HealingPower += attributes.HealingPower;  
    }
    //when an equip piece is equipped. Take the equipments attributes 
    //and add them to the running total of the player's attributes. 
    //also grab the ability list and place them into the player's spellbook
    private void OnEquip()
    {
        SpellBook.Clear();
        foreach(Equipment equipment in EquipmentPieces)
        {
            if(equipment)
            {
                AddSpells(equipment.GetAbilities());
                AddAttributes(equipment.GetAttributes());
            }
        }
    }
    //TODO: This is probly more complicated than it has to be. I'm a little sleepy
    private bool EquipTypeAlreadyEquipped(EquipmentType type)
    {
        foreach(Equipment equipment in EquipmentPieces) {
            if(equipment.Type == type)
            {
                return false;
            }
        }
        return true;
    }

    //Temporary method to equip pieces. 
    //When the ui is present, a new equip system will be needed
    public void EquipPiece(Equipment equipment)
    {
        for(int i=0;i<EquipmentPieces.Length;i++)
        {
            if(EquipmentPieces[i]==null || EquipmentPieces[i].Type==equipment.Type)
            {
                EquipmentPieces[i] = equipment;
                OnEquip();
                return;
            }
        }
    }
  
    public void CastAbility(int index)
    {
        
        if (SpellBook.Count>index)
        {
            Ability ability = SpellBook[index];
            ability.Initialize(this.gameObject);
            ability.Trigger();
        }
        else
        {
            //cannot cast ability. display some error message from the ui
        }
    }
    
}