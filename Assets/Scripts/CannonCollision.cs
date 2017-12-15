using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonCollision : MonoBehaviour {

    private int damage;
    private Rigidbody thisRb;

    void Awake()
    {
        thisRb = GetComponent<Rigidbody>();
    }
    void update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        Rigidbody check = collision.collider.GetComponent<Rigidbody>();
       
        Destroy(gameObject);

      
        Debug.Log("i can english");
    }
}
