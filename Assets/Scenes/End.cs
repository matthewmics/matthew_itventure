using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CnControls;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour {

	public GameObject EndPanel;
	// Use this for initialization
	void Start () {
		Invoke ("ShowEnd",15f);
	}
	
	// Update is called once per frame
	void Update () {
		if (CnInputManager.GetButtonDown ("ReturnToMenu")) {
			SceneManager.LoadScene ("mainMenu");
		}
	}

	public void ShowEnd (){
		EndPanel.SetActive (true);
	}

	public void ReturnToMenu(){
		SceneManager.LoadScene ("mainMenu");
	}
}
