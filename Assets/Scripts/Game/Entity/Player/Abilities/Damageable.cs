using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Damageable : MonoBehaviour {

    public IntegerVariable Health;
    public void Damage(int value)
    {
        Health.RuntimeValue -= value;
    }

}
