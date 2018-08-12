using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Variables/Float")]
public class FloatVariable : ScriptableObject,
    ISerializationCallbackReceiver{
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
