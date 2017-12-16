using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonCollision : MonoBehaviour {

    private int damage = 1;
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
        var durp = collision.gameObject.GetComponent<Movement>();
        if(durp != null)
        {
            durp.takeDamage(damage);
        }
        Destroy(gameObject);

      
        Debug.Log("i can english");
    }
}
