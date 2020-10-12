using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenderControl : MonoBehaviour {

	public static bool isCheckPoint = false;
	// Use this for initialization
	void Start () {
		if (PlayerPrefs.GetString ("Gender").Equals ("Male")) {
			transform.GetChild (0).gameObject.SetActive (true);
		} else {
			transform.GetChild (1).gameObject.SetActive (true);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
