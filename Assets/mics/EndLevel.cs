using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour {

	public int Level = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.CompareTag ("Player")) {

			if (Level > PlayerPrefs.GetInt ("Level")) {
				PlayerPrefs.SetInt ("Level",Level);
			}

			Invoke ("loadTrans",1.0f);
			other.transform.Find("Teleporting").gameObject.SetActive(true);
			gameObject.SetActive (false);
		}
	}

	void loadTrans(){

		SceneManager.LoadScene ("PostLevel");
	}
}
