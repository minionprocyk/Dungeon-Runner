using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Variables/Long")]
public class LongVariable : ScriptableObject,
    ISerializationCallbackReceiver
{

    public long Value;
    public long RuntimeValue;

    public void OnAfterDeserialize()
    {
        RuntimeValue = Value;
    }

    public void OnBeforeSerialize()
    {
    }
}
