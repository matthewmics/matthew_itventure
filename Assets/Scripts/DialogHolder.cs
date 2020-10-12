using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CnControls;

public class DialogHolder : MonoBehaviour {
	private DialogManager dMan;
	public int trackPlay;
	public string[] myDialogLines;
	public int questId;
	// Use this for initialization
	void Start () {
		dMan = FindObjectOfType<DialogManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerStay2D(Collider2D other){
		PlayerController.isTalking = true;
		if (other.gameObject.tag == "Player") {
			
			if(CnInputManager.GetButtonUp("Fire1") && dMan.dialogActive == false){
				dMan.currentLine = 0;
				dMan.dialogLines = myDialogLines;
				dMan.ShowDialog (questId);
				gameObject.SetActive (false);
			}

		}
	}
}
