using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityManager : MonoBehaviour
{

    [SerializeField] private List<Planet> planets = new List<Planet>();


    [SerializeField] private List<Rigidbody> objectsInfluencedByThePlanetGravity = new List<Rigidbody>();

    
    public static GravityManager Instance {
        get; private set; 
    }    
    private void Awake() {        
        Instance = this;    
    }
    
    
    private void Start()
    {
        if (objectsInfluencedByThePlanetGravity.Count == 0) 
            FixTheRigidbodyList();

    }

    [ContextMenu("FixTheRigidbodyList function")]
    public void FixTheRigidbodyList()
    {
        
        print("Im getting the list of Rigidbody when the game start. ideally only run this code when change the space ship.");
        
        objectsInfluencedByThePlanetGravity.Clear();
        
        Rigidbody[] objectsInfluencedByThePlanetGravityArray = (Rigidbody[]) GameObject.FindObjectsOfType (typeof(Rigidbody));
        
        objectsInfluencedByThePlanetGravity.AddRange(objectsInfluencedByThePlanetGravityArray);
    }
    

    private void FixedUpdate()
    {
        //here make gravity over all the objects on the list base on the distance from the planet and the gravity of the planet
        foreach (Rigidbody rbToAttract in objectsInfluencedByThePlanetGravity)
        {
            //for now we are using just one planet. Todo fix the vector to work with multiple planets. im using just the first one planets[0]
            Attract(rbToAttract, planets[0]);
        }
    }
    
    
    void Attract(Rigidbody rbToAttract,Planet onePlanet)
    {
        
        Vector3 direction = onePlanet.GetPlanetPosition() - rbToAttract.position;
        float distance = direction.magnitude;

        if (distance==0f)
            return;

        float forceMagnitude = onePlanet.GetPlanetGravity() * (onePlanet.GetPlanetMass() * rbToAttract.mass) / Mathf.Pow(distance,2);
        Vector3 force = direction.normalized * forceMagnitude;

        rbToAttract.AddForce(force);
    }
    
    
}
