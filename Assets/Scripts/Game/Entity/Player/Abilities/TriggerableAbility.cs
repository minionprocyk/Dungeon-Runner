using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public abstract class TriggerableAbility : MonoBehaviour {
    private AudioSource audioSource;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public abstract void Initialize();
        

    public virtual void Trigger(Ability ability)
    {
        //ability.Initialize(this.gameObject);
        //ability.Trigger();
        ability.AbilitySound.Play(audioSource);
    }
}
