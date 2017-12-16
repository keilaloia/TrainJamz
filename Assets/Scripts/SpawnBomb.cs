using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBomb : MonoBehaviour {

    private float crapTime = .65f;
    private float Timer;

    private Vector3 bombRadius;

    public GameObject bombPrefab;
    private Vector3 SpawnRadius;
	// Use this for initialization
	void Awake ()
    {
        bombRadius = new Vector3(8f, 0, 12f);
        Timer = crapTime;
	}
	
	// Update is called once per frame
	void Update ()
    {
        Timez();
	}

    void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(transform.position, bombRadius);
    }

    void BombsAway()
    {
        SpawnRadius = new Vector3(Random.Range(-4f, 4f), 0, Random.Range(-6f, 6f));
        GameObject BombBaby = Instantiate(bombPrefab);


        BombBaby.transform.position = transform.position + SpawnRadius;
    }

    void Timez()
    {

        Timer -= Time.deltaTime;
        if (Timer <= 0)
        {
            BombsAway();
            Timer = crapTime;
        }
    }
}
