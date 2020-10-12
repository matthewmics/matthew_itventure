using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void GoFade(){
		gameObject.SetActive (false);
	}

	void OnEnable(){

		Invoke ("GoFade",1.5f);
	}
}
