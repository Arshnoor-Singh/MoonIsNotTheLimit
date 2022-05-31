using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameInputManager : MonoBehaviour
{
    public Slider slider1;
    public Slider slider2;
    public Slider slider3;
    public Slider slider4;
    public Slider slider5;
    public Slider slider6;
    public Slider slider7;
    public Slider slider8;
    public Slider slider9;

    

    [SerializeField] private List<CombustionChamber> combustionGroup1 = new List<CombustionChamber>();
    [SerializeField] private List<CombustionChamber> combustionGroup2 = new List<CombustionChamber>();
    [SerializeField] private List<CombustionChamber> combustionGroup3 = new List<CombustionChamber>();
    [SerializeField] private List<CombustionChamber> combustionGroup4 = new List<CombustionChamber>();
    [SerializeField] private List<CombustionChamber> combustionGroup5 = new List<CombustionChamber>();
    [SerializeField] private List<CombustionChamber> combustionGroup6 = new List<CombustionChamber>();
    [SerializeField] private List<CombustionChamber> combustionGroup7 = new List<CombustionChamber>();
    [SerializeField] private List<CombustionChamber> combustionGroup8 = new List<CombustionChamber>();
    [SerializeField] private List<CombustionChamber> combustionGroup9 = new List<CombustionChamber>();

    
    
    
    
    public void Start()
    {
        slider1.onValueChanged.AddListener(OnValueChange_slider1);//use this function in case want to change the UI when acelerate...
    }
    public void OnValueChange_slider1(float value)
    {
        //use this function in case want to change the UI when acelerate...
    }


    private void FixedUpdate()
    {
        
        print(slider1.value);

        foreach (var VARIABLE in combustionGroup1)
            VARIABLE.IgniteChamber(slider1.value);
        
        foreach (var VARIABLE in combustionGroup2)
            VARIABLE.IgniteChamber(slider2.value);
        
        foreach (var VARIABLE in combustionGroup3)
            VARIABLE.IgniteChamber(slider3.value);
        
        foreach (var VARIABLE in combustionGroup4)
            VARIABLE.IgniteChamber(slider4.value);
        
        foreach (var VARIABLE in combustionGroup5)
            VARIABLE.IgniteChamber(slider5.value);
        
        foreach (var VARIABLE in combustionGroup6)
            VARIABLE.IgniteChamber(slider6.value);
        
        foreach (var VARIABLE in combustionGroup7)
            VARIABLE.IgniteChamber(slider7.value);
        
        foreach (var VARIABLE in combustionGroup8)
            VARIABLE.IgniteChamber(slider8.value);
        
        foreach (var VARIABLE in combustionGroup9)
            VARIABLE.IgniteChamber(slider9.value);
        
    }
}
