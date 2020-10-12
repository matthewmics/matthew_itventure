using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyHealthManager : MonoBehaviour {

	public int HealthMax;
	public int HealthCurrent;
	public GameObject healthpickup;
	public int stageId;
	public GameObject Itemdrop;
	public int chance = 3;
	public GameObject BossDefMessage;

	// Use this for initialization
	void Start () {
		SetEnemyMaxHealth ();	
	}

	public void HealEnemy(int healValue){
		HealthCurrent += healValue;
	}
	public void HurtEnemy(int hurtValue){
		HealthCurrent -= hurtValue;
	}

	public void NextScene(){
		
	}
	// Update is called once per frame
	void Update () {
		if (HealthCurrent <= 0) {
			Destroy (gameObject);
			//FindObjectOfType<QuestManager> ().KillEnemy (stageId);
			if (Random.Range (0, 12) <= chance)
				Instantiate (healthpickup, transform.position, Quaternion.Euler (Vector3.zero));

			if (CompareTag ("Boss")) {
				if (SceneManager.GetActiveScene ().buildIndex == 5) {
					
					//Time.timeScale = 0.0f;
					Itemdrop.SetActive(true);
					BossDefMessage.SetActive (true);	
					// do something..
				} else {
					//SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
					Itemdrop.SetActive(true);
					BossDefMessage.SetActive (true);	
					Debug.Log ("Boss defeated");
				}
			}

			else if (transform.parent.childCount < 2) {
				transform.parent.gameObject.SetActive (false);
			}
		}
	}
	public void SetEnemyMaxHealth(){
		HealthCurrent = HealthMax;
	}
}
