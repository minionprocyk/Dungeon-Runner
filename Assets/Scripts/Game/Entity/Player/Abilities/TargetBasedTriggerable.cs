using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBasedTriggerable : TriggerableAbility {

    private readonly GameObject SelectedTarget;
    void Start () {
		
	}
    public override void Initialize()
    {
        throw new System.NotImplementedException();
    }

    public override void Trigger(Ability ability)
    {
        base.Trigger(ability);

        //gotta get the SelectedTarget somehow

        Entity target = SelectedTarget.GetComponent<Entity>();
        
        //apply the ability to the target
        
    }
}
