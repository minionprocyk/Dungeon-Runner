using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Variables/Integer")]
public class IntegerVariable : ScriptableObject, 
    ISerializationCallbackReceiver {

    public int Value;
    public int RuntimeValue;

    public void OnAfterDeserialize()
    {
        RuntimeValue = Value;
    }

    public void OnBeforeSerialize()
    {
    }
}
