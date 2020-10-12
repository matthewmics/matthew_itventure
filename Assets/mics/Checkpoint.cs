using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {

	public string CheckpointScene;
	// Use this for initialization
	void Start () {
		if (PlayerPrefs.GetInt(CheckpointScene) == 1) {
			transform.GetChild (1).gameObject.SetActive (true);
		} else {

			transform.GetChild (0).gameObject.SetActive (true);
		
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
