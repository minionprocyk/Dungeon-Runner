using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Player))]
public class PlayerController : MonoBehaviour {

    [Range(0f, 1f)]
    public float ButtonHeldThreshold = 0.5f;
    private float _buttonHeld = 0f;

    private bool pressedAbilityOne = false;
    private bool pressedAbilityTwo = false;
    [SerializeField]
    private GameObject InventoryMenu;
    [SerializeField]
    private TargetSelector Target;
    private Player player;
    private void Start()
    {
        player = GetComponent<Player>();
    }


    private delegate void PerformAbility(int ability); 

    //If ability held for at least threshold, then target and cast
    private void IfAbilityHeld(PerformAbility method,int ability, ref bool abilityPressed)
    {
        _buttonHeld += Time.deltaTime;
        if (_buttonHeld >= ButtonHeldThreshold && abilityPressed== false)
        {
            method.Invoke(ability);
            abilityPressed = true;
        }
    }
    //If ability held less than threshold then cast
    private void IfAbilityNotHeld(PerformAbility method, int ability, ref bool abilityPressed)
    {
        abilityPressed = false;
        if (_buttonHeld < ButtonHeldThreshold)
        {
            method.Invoke(ability);
        }
    }
    private void SelectTargetAndCastAbility(int ability)
    {
        Target.SelectTarget();
        player.CastAbility(ability);
    }

    void Update () {
	    	
        if(Input.GetButtonDown("Inventory"))
        {
            InventoryMenu.SetActive(!InventoryMenu.activeSelf);
        }
        else if(Input.GetButton("Ability1"))
        {
             IfAbilityHeld(SelectTargetAndCastAbility,0,ref pressedAbilityOne);
        }
        else if(Input.GetButtonUp("Ability1"))
        {
            IfAbilityNotHeld(player.CastAbility, 0, ref pressedAbilityOne);
        }
        else if(Input.GetButton("Ability2"))
        {
            IfAbilityHeld(SelectTargetAndCastAbility, 1, ref pressedAbilityTwo);
        }
        else if(Input.GetButtonUp("Ability2"))
        {
            IfAbilityNotHeld(player.CastAbility, 1, ref pressedAbilityTwo);

        }
        else
        {
            _buttonHeld = 0f;
        }
        
    }

}
