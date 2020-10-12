using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {
	public Slider healthBar;
	public Text HealthText;
	public PlayerHealthManager playerHealth;

	private static bool UIExists;
	// Use this for initialization
	void Start () {
		if (!UIExists) {
			UIExists = true;
			//DontDestroyOnLoad (transform.gameObject);
		} else {

			//Destroy (gameObject);
		}
		playerHealth = FindObjectOfType<PlayerHealthManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (playerHealth == null) {
			playerHealth = FindObjectOfType<PlayerHealthManager> ();
		}
		healthBar.maxValue = playerHealth.playerHealthMax;
		healthBar.value = playerHealth.playerHealthCurrent;
		HealthText.text = "HP: " + playerHealth.playerHealthCurrent + "/" + playerHealth.playerHealthMax;
	}
}
