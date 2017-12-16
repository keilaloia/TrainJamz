using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Win : MonoBehaviour {

    public UnityEvent onwin;
	void OnCollisionEnter(Collision collision)
    {
        onwin.Invoke();
        Destroy(gameObject.transform.parent.gameObject);

        
    }
}
