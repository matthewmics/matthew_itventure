using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointTrigger : MonoBehaviour {

	public GameObject CheckpointMessage;
	public string CheckpointScene;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.CompareTag("Player")){
			CheckpointMessage.SetActive (true);
			//GenderControl.isCheckPoint = true;
			PlayerPrefs.SetInt(CheckpointScene,1);
		}
	}
}
