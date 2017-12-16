using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Movement : MonoBehaviour {

    // Use this for initialization

    public UnityEvent OnDead;

    public float speed;
    private Rigidbody RB;
    private Vector3 Dir;
    private Collider Bounds;

    public float JumpHeight;
    private float horz;
    private float vert;
    public int health = 2;

    public bool isGrounded
    {
        get
        {
            Vector3 startPoint = transform.position + (Vector3.down * Bounds.bounds.extents.y * .9f);
            Vector3 endPoint = startPoint + (Vector3.down * Bounds.bounds.extents.y * .2f);
            Debug.DrawLine(startPoint, endPoint, Color.red);
            return Physics.Raycast(startPoint, Vector3.down, Bounds.bounds.extents.y * .2f);
        }
    }
    void Start ()
    {
        RB = gameObject.GetComponent<Rigidbody>();
        Bounds = gameObject.GetComponent<Collider>();
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        Moves();
        JumpShip();
       
	}


    void Moves()
    {
        if(Input.GetKey(KeyCode.W))
        {
            vert += 1.5f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            vert -= 1.5f;
        }

        if (Input.GetKey(KeyCode.A))
        {
            horz -= 1.5f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            horz += 1.5f;
        }
        
        if(Mathf.Abs(horz) > 10)
        {
            horz = 10;
        }
        if (Mathf.Abs(vert) > 10)
        {
            vert = 10;
        }


        Dir = new Vector3(horz * speed * Time.deltaTime, RB.velocity.y, vert * speed * Time.deltaTime);

        RB.velocity = Dir;

        horz *= .8f;
        vert *= .8f;

    }


    void JumpShip()
    {
        if(Input.GetKey(KeyCode.Space) && isGrounded)
        {
            RB.velocity = new Vector3(RB.velocity.x, JumpHeight, RB.velocity.y);
        }
        else if(!isGrounded)
        {
            RB.AddForce(Physics.gravity * RB.mass * 1.5f);
            Debug.Log("being called");
        }
    }

    public void takeDamage(int damageTaken)
    {
        health -= damageTaken;
        healthManager();
    }

    void healthManager()
    {
        if(health <= 0)
        {
            OnDead.Invoke();
            Debug.Log("lose");
        }
    }
}
