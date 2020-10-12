using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CnControls;

public class Resume : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (CnInputManager.GetButtonDown ("Pause")) {
			Time.timeScale = 1.0f;
			gameObject.SetActive (false);
		}
	}
}
