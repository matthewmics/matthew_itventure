using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour {

	public int playerHealthMax;
	public int playerHealthCurrent;

	private bool flashActive;
	public float flashLength;
	private float flashLengthC;


	// Use this for initialization
	void Start () {
		SetPlayerMaxHealth ();	
		Time.timeScale = 1.0f;
	}

	public void HealPlayer(int healValue){
		if((playerHealthCurrent + healValue) > playerHealthMax)
		{
			SetPlayerMaxHealth();
		}
		else{
			
			playerHealthCurrent += healValue;
		}	
	}
	public void HurtPlayer(int hurtValue){

		flashActive = true;	
		playerHealthCurrent -= hurtValue;
		if (playerHealthCurrent <= 0) {
			FindObjectOfType<QuestManager> ().ShowGameOver ();
		}
		flashLengthC = flashLength;

	}

	// Update is called once per frame
	void Update () {
		if (playerHealthCurrent <= 0) {
			Time.timeScale =0.0f;
		}
		if (flashActive) {
			if (flashLengthC > flashLength * .66f) {
				SpriteRenderer playerSprite = gameObject.GetComponent<SpriteRenderer> ();
				playerSprite.color = new Color (playerSprite.color.r, playerSprite.color.g, playerSprite.color.b, 0f);
			} else if (flashLengthC > flashLength * .33f) {
				SpriteRenderer playerSprite = gameObject.GetComponent<SpriteRenderer> ();
				playerSprite.color = new Color (playerSprite.color.r, playerSprite.color.g, playerSprite.color.b, 1f);
			} else if (flashLengthC > 0f) {
				SpriteRenderer playerSprite = gameObject.GetComponent<SpriteRenderer> ();
				playerSprite.color = new Color (playerSprite.color.r, playerSprite.color.g, playerSprite.color.b, 0);
			}else{
				SpriteRenderer playerSprite = gameObject.GetComponent<SpriteRenderer> ();
				playerSprite.color = new Color (playerSprite.color.r, playerSprite.color.g, playerSprite.color.b, 1f);
				flashActive = false;
			}
			flashLengthC -= Time.deltaTime;
		}
	}
	public void SetPlayerMaxHealth(){
		playerHealthCurrent = playerHealthMax;
	}
}
