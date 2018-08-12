using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class TriggerAbility : MonoBehaviour {
    [SerializeField]
    private  Ability ability;
    private AudioSource audioSource;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update () {
        if(Input.GetMouseButtonDown(0))
        {
            ability.Initialize(this.gameObject);
            ability.Trigger();
            ability.AbilitySound.Play(audioSource);

            GameObject fromObject = PlayerManager.instance.player;
            Instantiate(ability.AbilityEffect, fromObject.transform.position,fromObject.transform.rotation);
        }
	}
}
