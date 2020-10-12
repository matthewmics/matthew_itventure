using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Prologue : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke ("donePrologue",2.5f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void donePrologue(){
		SceneManager.LoadScene ("mapSelect");
	}


}
