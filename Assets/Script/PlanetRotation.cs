using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    public Rigidbody rb;
    public float speedY;
    public float speedZ;
    public float torque;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddTorque(transform.up * torque * speedY);
    }

    void FixedUpdate()
    {
        rb.AddTorque(transform.forward * torque * speedZ);
    }
}
