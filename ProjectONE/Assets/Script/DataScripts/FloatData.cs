using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public float value = 1f;
    public float minValue = 0, maxValue = 1;

    public void UpdateValue(float amount)
    {
        value += amount;
    }

    public void UpdateValueRange(float amount)
    {
        if (value < maxValue)
        {
            UpdateValue(amount);
        }
        else
        {
            value = maxValue;
        }

        if (value >= minValue)
        {
            UpdateValue(amount);
        }
        else
        {
            value = minValue;
        }
    }

}
