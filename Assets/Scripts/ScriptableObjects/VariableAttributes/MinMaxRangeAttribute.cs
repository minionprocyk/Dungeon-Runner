using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinMaxRangeAttribute : PropertyAttribute {
    public MinMaxRangeAttribute(float min, float max)
    {
        this.Min = min;
        this.Max = max;
    }
    public float Min { get; private set; }
    public float Max { get; private set; }
}
