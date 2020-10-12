using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour {

	public AudioSource[] bgm;

	public int currentTrack;

	public bool musicCanPlay;

	private static bool mcExists;
	// Use this for initialization
	void Start () {
		if (!mcExists) {
			mcExists = true;
			//DontDestroyOnLoad (transform.gameObject);
		} else {

			//Destroy (gameObject);
		}

        foreach (AudioSource aa in bgm)
        {
            aa.volume = VolumeManager.volume;
        }
    }
	
	// Update is called once per frame
	void Update () {
		if (musicCanPlay) {
			if (!bgm [currentTrack].isPlaying) {
				bgm [currentTrack].Play ();
			}
		} else {
			bgm [currentTrack].Stop();
		}

        
	}

	public void SwitchTrack(int newTrack){
		bgm [currentTrack].Stop();
		currentTrack = newTrack;
		bgm [currentTrack].Play ();
	}
}
