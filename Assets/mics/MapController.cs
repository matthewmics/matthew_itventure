using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Level = PlayerPrefs.GetInt ("Level");
	}
	int Level;
	// Update is called once per frame
	void Update () {
		for (int i = 0; i < Level; i++) {
			transform.GetChild (i).gameObject.SetActive (true);
		}
	}
}
