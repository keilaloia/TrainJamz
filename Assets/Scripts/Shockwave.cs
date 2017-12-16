using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shockwave : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        shockWave();
	}

    void shockWave()
    {
        transform.parent.localScale += new Vector3(12f * Time.deltaTime, 0, 12f * Time.deltaTime);
        Destroy(gameObject.transform.parent.gameObject, 1f);
    }

    void OnCollisionEnter(Collision collision)
    {
        Rigidbody PlayerRB = collision.collider.GetComponent<Rigidbody>();

        Vector3 Dir = PlayerRB.position - transform.parent.position;

        PlayerRB.position += (Dir.normalized * 10) * Time.deltaTime * 10;
    }
}
