using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Variables/Integer")]
public class IntegerVariable : ScriptableObject, 
    ISerializationCallbackReceiver {

    public float Value;
    public float RuntimeValue;

    public void OnAfterDeserialize()
    {
        RuntimeValue = Value;
    }

    public void OnBeforeSerialize()
    {
    }
}
