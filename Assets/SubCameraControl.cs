using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubCameraControl : MonoBehaviour {

    GameObject Ball;

	// Use this for initialization
	void Start () {
        Ball = GameObject.Find("Ball");
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Ball.transform.position;
	}
}
