using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{

    [SerializeField] private float gravity = 9.8f;
    public float GetGravity() => gravity;


    public Vector3 GetPlanetPosition()
    {
        return this.transform.position;
    }
    
    
    
}
