using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SFXToggle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if (!PlayerPrefs.HasKey ("sfx")) {
			PlayerPrefs.SetInt ("sfx", 1);
		}

		if (PlayerPrefs.GetInt("sfx") == 1) {
			GetComponent<Toggle> ().isOn = true;
		} else {
			GetComponent<Toggle> ().isOn = false;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ToggleSounds()
	{
		if (GetComponent<Toggle> ().isOn) {
			PlayerPrefs.SetInt ("sfx", 1);
		} else {
			PlayerPrefs.SetInt ("sfx", 0);
		}


	}
}
