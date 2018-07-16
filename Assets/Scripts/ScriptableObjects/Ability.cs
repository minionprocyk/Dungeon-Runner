using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ability : ScriptableObject {
    public string AbilityName = "New Ability";
    public Sprite AbilitySprite;
    public AudioClip AbilitySound;
    public float AbilityBaseCoolDown = 1f;

    public abstract void Initialize(GameObject obj);
    public abstract void Trigger();
}
