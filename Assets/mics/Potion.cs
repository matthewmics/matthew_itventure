using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CnControls;
using UnityEngine.UI;

public class Potion : MonoBehaviour {

	public float HealMultiplier = 0.2f;
	int CurrentPotion = 0;
	Text PotionStockText;
	public GameObject Player;

	// Use this for initialization
	void Start () {
		PotionStockText = transform.Find ("potionstock").transform.GetChild(0).gameObject.GetComponent<Text>();
		UpdatePotion ();
		//Player = GameObject.Find ("Player(Clone)");
	}
	
	// Update is called once per frame
	void Update () {
		if (CnInputManager.GetButtonUp ("Potion")) {

			if (CurrentPotion > 0) {
				CurrentPotion--;
				int healammount = Mathf.RoundToInt ((Player.GetComponent<PlayerHealthManager> ().playerHealthMax * HealMultiplier));
				Player.GetComponent<PlayerHealthManager> ().HealPlayer (healammount);
				UpdatePotion ();
			}
		}



	}

	void UpdatePotion(){
		PotionStockText.text = CurrentPotion.ToString();
	}

	public void AddPotion(){
		
		CurrentPotion++;
		UpdatePotion ();
	}

	public void SetPlayer(GameObject Player){
		this.Player = Player;
	}

}
