using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerate : MonoBehaviour {

    public GameObject EnemyPrefab;
    float span = 0.2f;
    float delta = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.delta += Time.deltaTime;

        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(EnemyPrefab) as GameObject;
            int px = Random.Range(-50, 50);
            int pz = Random.Range(-50, 50);
            go.transform.position = new Vector3(px, 300, pz);
        }
    }
}
