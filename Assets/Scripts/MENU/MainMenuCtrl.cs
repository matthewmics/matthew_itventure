using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuCtrl : MonoBehaviour {

	// Use this for initialization
	GameObject mcanvas;
	void Start () {
		mcanvas = GameObject.Find ("MenuCanvas");
	}

	// Update is called once per frame
	void Update () {

	}
	public void LoadGameMenu(){
		mcanvas.transform.Find ("GameCreate").gameObject.SetActive (true);
		mcanvas.transform.Find ("MainGameMenu").gameObject.SetActive (false);
		mcanvas.transform.Find ("SettingsMenu").gameObject.SetActive (false);


	}
	public void LoadSettingsMenu(){
		mcanvas.transform.Find ("GameCreate").gameObject.SetActive (false);
		mcanvas.transform.Find ("MainGameMenu").gameObject.SetActive (false);
		mcanvas.transform.Find ("SettingsMenu").gameObject.SetActive (true);


	}
	public void BackToMainMenu(){
		mcanvas.transform.Find ("GameCreate").gameObject.SetActive (false);
		mcanvas.transform.Find ("MainGameMenu").gameObject.SetActive (true);
		mcanvas.transform.Find ("SettingsMenu").gameObject.SetActive (false);
	}

	public void QuitGame(){
		Application.Quit();
	}

	public void Credits(){
		SceneManager.LoadScene ("Credits");
	}
}
