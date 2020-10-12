using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMapSelect : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke ("LoadMap",1.5f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void LoadMap(){
		SceneManager.LoadScene ("mapSelect");
	}
}
