using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gender : MonoBehaviour {

	public GameObject Genders;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void setToMale(){
		MenuCtrl.gender = "Male";
		Genders.transform.GetChild (0).gameObject.SetActive (true);
		Genders.transform.GetChild (1).gameObject.SetActive (false);
	}

	public void setToFemale(){
		MenuCtrl.gender = "Female";
		Genders.transform.GetChild (1).gameObject.SetActive (true);
		Genders.transform.GetChild (0).gameObject.SetActive (false);
	}
}
