using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playlegacy : MonoBehaviour {

	public float interval = 5.0f;
	private float lastTime;

	// Use this for initialization
	void Start () {
		lastTime = Time.time + interval;
	}
	
	// Update is called once per frame
	void Update () {

		if (Time.time > lastTime) {
			GetComponent<Animation> ().Play ();
			lastTime = Time.time + interval;
		}

	}
}
