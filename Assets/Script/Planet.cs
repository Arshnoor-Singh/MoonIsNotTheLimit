using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{

    [SerializeField] private float planetGravity = 9.8f;
    public float GetPlanetGravity() => planetGravity;
    
    [SerializeField] private float planetMass = 1000000f;
    public float GetPlanetMass() => planetMass;


    public Vector3 GetPlanetPosition()
    {
        return this.transform.position;
    }
    
    
    
}
