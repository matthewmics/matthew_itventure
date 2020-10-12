using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour {

	public float HealMultiplier;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Player") {
			//int healammount = Mathf.RoundToInt ((other.GetComponent<PlayerHealthManager> ().playerHealthMax * HealMultiplier));
			//other.GetComponent<PlayerHealthManager> ().HealPlayer (healammount);

			GameObject.FindGameObjectWithTag ("Potion").GetComponent<Potion> ().AddPotion();
			GameObject.FindGameObjectWithTag ("Potion").GetComponent<Potion> ().SetPlayer (other.gameObject);
			Destroy (gameObject);
		}
	}
}
