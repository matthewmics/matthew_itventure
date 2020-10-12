using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeManager : MonoBehaviour {

	public static bool IsOn = true;
	public VolumeController[] vcObjects;
	public float currentVolumeLevel = 1.0f;
	public float MaxVolumeLevel = 1.0f;
	private static bool vmExists;
    public static float volume = 1.0f;

	// Use this for initialization
	void Start () {

		if (!PlayerPrefs.HasKey ("vol")) {
			PlayerPrefs.SetInt ("vol",1);
		}

			DontDestroyOnLoad (transform.gameObject);
		vcObjects = FindObjectsOfType<VolumeController> ();
		if (currentVolumeLevel > MaxVolumeLevel) {
			currentVolumeLevel = MaxVolumeLevel;
		}
		foreach (VolumeController vcObject in vcObjects) {
			vcObject.SetAudioLevel (currentVolumeLevel);	
		}


		float vol = 0.0f;
		if (PlayerPrefs.GetInt("vol") == 1) {
			vol = 1.0f;
		} else {
			vol = 0.0f;
		}
		SetVolumeLevels (vol);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void SetVolumeLevels(float newVolume){
		if (newVolume > MaxVolumeLevel) {
			currentVolumeLevel = MaxVolumeLevel;
		}else{
			currentVolumeLevel = newVolume;
		}
		foreach (VolumeController vcObject in vcObjects) {
			vcObject.SetAudioLevel (currentVolumeLevel);	
		}

        volume = newVolume;
	}
}
