using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringArm : MonoBehaviour {

    // how far I want the camera to be
    private Vector3 targetDist;

    // where I can actually go
    private Vector3 finalDist;

    public Transform moveableCamera;
    private Vector3 velocity = Vector3.zero;

	// Use this for initialization
	void Start ()
    {
        targetDist = new Vector3(0, 1.5f, -3f);
	}
	
	void LateUpdate ()
    {
        caste();
        moveableCamera.position = Vector3.SmoothDamp(moveableCamera.transform.position, finalDist, ref velocity, .1f);
    }

    void caste()
    {
        RaycastHit hit;

        if (Physics.Linecast(transform.position, transform.position + targetDist, out hit))
        {
            finalDist = hit.point + (transform.position - hit.point).normalized * 1 ;
        }

        else
            finalDist = targetDist + transform.position;
    }

   
}   

