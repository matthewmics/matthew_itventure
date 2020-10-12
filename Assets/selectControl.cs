using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectControl : MonoBehaviour {
	public GameObject smale;
	public GameObject sfemale;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void SetMale(int gend){
		if (gend == 0) {
			smale.SetActive (true);
			sfemale.SetActive (false);
		} else if (gend == 1) {
			smale.SetActive (false);
			sfemale.SetActive (true);
		}
	}
}
