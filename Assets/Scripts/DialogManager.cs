using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CnControls;
public class DialogManager : MonoBehaviour {

	public GameObject dBox;
	public Text dText;

	public int[] bgmtracks;
	private MusicController mcontroller;

	public bool dialogActive;
	public string[] dialogLines;
	public int currentLine;
	public PlayerController thePlayer;
	private int questId;
	// Use this for initialization
	void Start () {
		thePlayer = FindObjectOfType<PlayerController> ();
		mcontroller = FindObjectOfType<MusicController> ();
	}

	// Update is called once per frame
	void Update () {
		if (thePlayer == null) {
			thePlayer = FindObjectOfType<PlayerController> ();
		}
		//if (dialogActive && Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) {
		if (dialogActive && CnInputManager.GetButtonUp("Fire1")) {
			PlayerController.isTalking = true;
			//dBox.SetActive (false);
			//dialogActive = false;
			currentLine++;
		}
		if (currentLine >= dialogLines.Length) {
			dBox.SetActive (false);
			dialogActive = false;
			currentLine=0;
			mcontroller.SwitchTrack (bgmtracks [questId]);
			mcontroller.musicCanPlay = true;
			thePlayer.canMove = true;
			PlayerController.isTalking = false;

			if (questId == 0) {
				GameObject.Find ("door1").SetActive (false);
			}
			else if (questId == 1) {
				GameObject.Find ("door6").SetActive (false);
			}
		}
		dText.text = dialogLines [currentLine];
	}

	public void ShowDialog(int questIdx) {
		if (!dialogActive) {
			dialogActive = true;
			dBox.SetActive (true);
			thePlayer.canMove = false;
			questId = questIdx;
		}
	}
}
