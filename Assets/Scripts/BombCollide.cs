using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombCollide : MonoBehaviour {

    private Rigidbody RB;

    public GameObject Ring;
	// Use this for initialization
	void Awake ()
    {
        RB = gameObject.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OnCollisionEnter(Collision collision)
    {
        Destroy(RB.gameObject);

        GameObject Rings = Instantiate(Ring);
        Rings.transform.position = transform.position;
    }
}
