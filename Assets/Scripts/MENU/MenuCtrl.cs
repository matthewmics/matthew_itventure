using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using CnControls;
public class MenuCtrl : MonoBehaviour {

	public Text playerName;
	public static string gender = "Male";
	public GameObject QuitPanel;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (CnInputManager.GetButtonDown ("CancelQuit")) {
			QuitPanel.SetActive (false);
		}
		if (CnInputManager.GetButtonDown ("Quit")) {
			Application.Quit ();
		}
		if (CnInputManager.GetButtonDown ("OpenQuit")) {
			QuitPanel.SetActive (true);
		}
	}
	public void LoadScene(string sceneName)
	{
		
		if (!(playerName.text.Trim ().Equals (""))) {
			PlayerPrefs.SetInt ("Level",1);
			PlayerPrefs.SetString ("Username",playerName.text);
			PlayerPrefs.SetString ("Gender",gender);
			PlayerPrefs.SetInt ("Scene1C",0);
			PlayerPrefs.SetInt ("Scene2C",0);
			PlayerPrefs.SetInt ("Scene3C",0);
			PlayerPrefs.SetInt ("Scene4C",0);
			PlayerPrefs.SetInt ("Scene5C",0);
			SceneManager.LoadScene (sceneName);
		}
	}
	public void QuitGame(){
		QuitPanel.SetActive (true);
	}

	public void loadGame(){
		if (PlayerPrefs.HasKey ("Username")) {
			SceneManager.LoadScene ("mapSelect");
		}
	}
}
