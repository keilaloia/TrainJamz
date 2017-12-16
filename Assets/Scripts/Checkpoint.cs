using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {

    public GameObject player;
    public  bool ischecked;
    private Vector3 CheckPos;
    void update()
    {

    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Player")
        {
            ischecked = true;
            CheckPos = player.transform.position;
            
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            player.transform.position = CheckPos;

      }
    }
}
