using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiquidOxygen : MonoBehaviour
{
    [SerializeField] private float _oxygenAmount;

    private float _usedAmount;

    public float ReturnFuelAmount()
    {
        //aux function not in use yet
        return _oxygenAmount;
    }


    public float UseOxygen(float amountRequired)
    {
        //insert here the UI to change the color of the tank case _usedAmount == 0
        _usedAmount = Mathf.Clamp(amountRequired, amountRequired, _oxygenAmount);

        _oxygenAmount -= _usedAmount;
        
        return _usedAmount;
        
    }
}
