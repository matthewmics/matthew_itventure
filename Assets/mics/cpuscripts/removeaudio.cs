using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class removeaudio : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke ("removeaudio2",1.0f);
		if (PlayerPrefs.GetInt ("sfx") != 1) {
			Destroy (this.gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void removeaudio2(){
		Destroy(this.gameObject);
	}
}
