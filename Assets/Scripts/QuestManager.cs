using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CnControls;
using UnityEngine.SceneManagement;
public class QuestManager : MonoBehaviour {
	public int[] enemyPerStage;
	private int[] defaultEnemyPerStage;
	private GameObject thePlayer;
	private CameraController theCamera;

	public GameObject[] bosses;
	public bool[] bossSpawned;

	public GameObject WeaponLists;
	// Use this for initialization
	void Start () {
		thePlayer = GameObject.FindGameObjectWithTag ("Player");
		theCamera = FindObjectOfType<CameraController> ();
		gameObject.SetActive (true);
		defaultEnemyPerStage = enemyPerStage;

	}
	
	// Update is called once per frame
	void Update () {
		if (CnInputManager.GetButtonUp ("RestartLevel")) {
			Time.timeScale = 1.0f;
			SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);

		}

		if (CnInputManager.GetButtonUp ("CloseWeaponsList")) {
			WeaponLists.SetActive (false);

		}
		if (CnInputManager.GetButtonUp ("OpenWeaponsList")) {
			WeaponLists.SetActive (true);

		}

		if (CnInputManager.GetButtonUp ("ReturnToMenu")) {
			Time.timeScale = 1.0f;
			SceneManager.LoadScene ("mainMenu");

		}
	}
	public void KillEnemy(int stageId){
		
	}
	public void gameOver(){
		
	}
	public void ResetEnemies(){
		
	}

	public void ShowGameOver(){
		
		transform.GetChild (0).gameObject.SetActive (true);
	}



}
