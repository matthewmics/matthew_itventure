using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSelect : MonoBehaviour {

    public GameObject[] loadingScreens;

	public void selectMap1(){
		GenderControl.isCheckPoint = false;
        loadingScreens[0].SetActive(true);
		SceneManager.LoadScene ("scene1");
		PlayerPrefs.SetInt ("Scene2C",0);
		PlayerPrefs.SetInt ("Scene3C",0);
		PlayerPrefs.SetInt ("Scene4C",0);
		PlayerPrefs.SetInt ("Scene5C",0);
	}
	public void selectMap2()
	{
		GenderControl.isCheckPoint = false;
        loadingScreens[1].SetActive(true);
        SceneManager.LoadScene ("scene2");
		PlayerPrefs.SetInt ("Scene1C",0);
		PlayerPrefs.SetInt ("Scene3C",0);
		PlayerPrefs.SetInt ("Scene4C",0);
		PlayerPrefs.SetInt ("Scene5C",0);
	}
	public void selectMap3()
	{
		GenderControl.isCheckPoint = false;
        loadingScreens[2].SetActive(true);
        SceneManager.LoadScene ("scene3");

		PlayerPrefs.SetInt ("Scene1C",0);
		PlayerPrefs.SetInt ("Scene2C",0);
		PlayerPrefs.SetInt ("Scene4C",0);
		PlayerPrefs.SetInt ("Scene5C",0);
	}
	public void selectMap4()
	{
		GenderControl.isCheckPoint = false;
        loadingScreens[3].SetActive(true);
        SceneManager.LoadScene ("scene4");

		PlayerPrefs.SetInt ("Scene1C",0);
		PlayerPrefs.SetInt ("Scene3C",0);
		PlayerPrefs.SetInt ("Scene2C",0);
		PlayerPrefs.SetInt ("Scene5C",0);
	}
	public void selectMap5()
	{
		GenderControl.isCheckPoint = false;
        loadingScreens[4].SetActive(true);
        SceneManager.LoadScene ("scene5");

		PlayerPrefs.SetInt ("Scene1C",0);
		PlayerPrefs.SetInt ("Scene3C",0);
		PlayerPrefs.SetInt ("Scene4C",0);
		PlayerPrefs.SetInt ("Scene2C",0);
	}

	public void selectMenu(){
		SceneManager.LoadScene ("mainMenu");
	}


}
