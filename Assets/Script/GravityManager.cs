using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityManager : MonoBehaviour
{

    [SerializeField] private List<Planet> planets = new List<Planet>();


    [SerializeField] private List<Rigidbody> objectsInfluencedTheGravity = new List<Rigidbody>();
    
    

    public static GravityManager Instance {
        get; private set; 
    }    
    private void Awake() {        
        Instance = this;    
    }


    private void FixedUpdate()
    {
        
        //here make gravity over all the objects on the list base on the distance from the planet and the gravity of the planet
        
        
        
    }
}
