using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravitationalPull : MonoBehaviour
{
   public Rigidbody rb; //get the rigid body
   const float G = 667.4f;

   public static List<GravitationalPull> Attractors;

    void FixedUpdate()
    {
       // GravitationalPull[] attractors = FindObjectsOfType<GravitationalPull>();
        foreach (GravitationalPull attractor in Attractors)
        {
            if (attractor != this)
            Attract(attractor);
        }
    }
    
    void OnEnable ()
    {
        if(Attractors == null)
            Attractors = new List<GravitationalPull>();

        
        Attractors.Add(this);
    }

    void OnDisable ()
    {
        Attractors.Remove(this);
    }

   void Attract(GravitationalPull objToAttract)
   {
       Rigidbody rbToAttract = objToAttract.rb;

       Vector3 direction = rb.position - rbToAttract.position;
       float distance = direction.magnitude;

       if (distance==0f)
            return;

       float forceMagnitude = G * (rb.mass * rbToAttract.mass) / Mathf.Pow(distance,2);
       Vector3 force = direction.normalized * forceMagnitude;

       rbToAttract.AddForce(force);
   }
}
