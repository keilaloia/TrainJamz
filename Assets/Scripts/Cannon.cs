using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour {

    public float shootforce;
    public GameObject CannonPrefab;
    private Rigidbody RB;
    public float Craptime;
    private float Timer;
    private Vector3 localForward;

    void Awake ()
    {
        Timer = Craptime;
        localForward = transform.worldToLocalMatrix.MultiplyVector(transform.forward);
    }

	void Update ()
    {
        Timez();
	}

    void SpawnCannon()
    {
        GameObject CannonCrapper = Instantiate(CannonPrefab, transform.position, Quaternion.identity);
        RB = CannonCrapper.GetComponent<Rigidbody>();
        
        CannonCrapper.transform.forward = transform.forward;

        RB.AddForce(RB.transform.forward * shootforce, ForceMode.Impulse);
       
    }

    void Timez()
    {
        Timer -= Time.deltaTime;
        if(Timer <= 0)
        {
            SpawnCannon();
            Timer = Craptime;
        }
    }
}
