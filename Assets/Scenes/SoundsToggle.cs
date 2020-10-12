using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundsToggle : MonoBehaviour {

	public GameObject sounds;
	// Use this for initialization
	void Start () {

		float vol = 0.0f;
		if (PlayerPrefs.GetInt("vol") == 1) {
			GetComponent<Toggle> ().isOn = true;
			vol = 1.0f;
		} else {
			GetComponent<Toggle> ().isOn = false;
			vol = 0.0f;
		}


	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ToggleSounds()
	{
		float vol = 0.0f;
		VolumeManager.IsOn = false;
		PlayerPrefs.SetInt ("vol",0);
		if (GetComponent<Toggle> ().isOn) {
			vol = 1.0f;
			PlayerPrefs.SetInt ("vol",1);
		} 

		sounds.GetComponent<VolumeManager> ().SetVolumeLevels (vol);

	}

}
