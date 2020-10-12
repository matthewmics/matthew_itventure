using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CnControls;

public class Pause : MonoBehaviour {

	public GameObject PausePanel;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (CnInputManager.GetButtonDown ("Cancel")) {
			//Application.Quit ();
			Time.timeScale = 0.0f;
			PausePanel.SetActive (true);
		}
	}
}
