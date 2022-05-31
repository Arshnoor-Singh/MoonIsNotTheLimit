using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiquidFuel : MonoBehaviour
{
    [SerializeField] private float _fuelAmount;

    private float _usedAmount;

    public float ReturnFuelAmount()
    {
        //aux function not in use yet
        return _fuelAmount;
    }


    public float UseFuel(float amountRequired)
    {
        //insert here the UI to change the color of the tank case _usedAmount == 0
        _usedAmount = Mathf.Clamp(amountRequired, amountRequired, _fuelAmount);

        _fuelAmount -= _usedAmount;
        
        return _usedAmount;
    }
    
    

    

}
