using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombustionChamber : MonoBehaviour
{

    [SerializeField] private ParticleSystem _particleSystem;

    [SerializeField] private List<LiquidFuel> _listOfLiquidFuel = new List<LiquidFuel>();
    [SerializeField] private List<LiquidOxygen> _listOfLiquidOxigen = new List<LiquidOxygen>();
    
    [SerializeField] private float chamberForcePerFixedUpdateInAmountOfFuelUsed;
    
    
    
    private Rigidbody _rigidbody;
    private   float _fuel;
    private   float _oxygen;


        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
            _particleSystem.Pause();
        }


        public void IgniteChamber(float acceleratorForce)
    {

        if (acceleratorForce == 0)
        {
            return;
        }

        //amount used 
        _fuel = 0;
        _oxygen = 0;
        
        
        foreach (var VARIABLE in _listOfLiquidFuel)
        {
            
            _fuel +=  VARIABLE.UseFuel(chamberForcePerFixedUpdateInAmountOfFuelUsed * acceleratorForce);
            if (_fuel >= chamberForcePerFixedUpdateInAmountOfFuelUsed * acceleratorForce) //Todo this if is wrong, im using the fuel one more frame than necessary. pending replace it with a clamp
            {
                break;
            }
        }
        
        foreach (var VARIABLE in _listOfLiquidOxigen)
        {
            _oxygen += VARIABLE.UseOxygen(chamberForcePerFixedUpdateInAmountOfFuelUsed * acceleratorForce);
            if (_oxygen >= chamberForcePerFixedUpdateInAmountOfFuelUsed * acceleratorForce) //Todo this if is wrong, im using the oxygen one more frame than necessary. pending replace it with a clamp
            {
                break;
            }
        }


        if (_fuel == 0)
        {
            print("no fuel");
            //Todo no fuel . create here the VFX with yellow smoke from fuel escaping
        }
        else if  (_oxygen == 0)
        {
            print("no oxygen");
            //Todo  oxygen. create here the VFX with white smoke from the oxygen escaping.
        }
        else
        {
            _rigidbody.AddRelativeForce(Vector3.up * acceleratorForce* chamberForcePerFixedUpdateInAmountOfFuelUsed,ForceMode.Force);
            //VFX with fire
            _particleSystem.Emit((int)acceleratorForce);
        }
        

        
        
    }
    

}
