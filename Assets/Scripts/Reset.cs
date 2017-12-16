using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour {

    public GameObject player;
    private Vector3 originPos;
	// Use this for initialization
	void Start ()
    {
        originPos = player.transform.position;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            player.transform.position = originPos;

        }
    }
}
