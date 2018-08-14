﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ability : ScriptableObject {
    public string AbilityName = "New Ability";
    public GameObject AbilityEffect;
    public Sprite AbilitySprite;
    public SimpleAudioSource AbilitySound;
    public float AbilityBaseCoolDown = 1f;

    public abstract void Initialize(GameObject obj);
    public abstract void Trigger();
}