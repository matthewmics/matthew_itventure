using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtEnemy : MonoBehaviour {
	public int damageToGive;
	public GameObject damageFx;
	public Transform hitPoint;
	public GameObject damageText;
	public GameObject hitsound;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "ESDEnemies" || other.gameObject.tag == "OfficeEnemies" ||other.gameObject.tag == "FireEnemies" || other.gameObject.tag == "DustEnemies" || other.gameObject.tag == "Boss") {
			other.gameObject.GetComponent<EnemyHealthManager> ().HurtEnemy (damageToGive);

			GameObject.Instantiate (hitsound);

			var clone = (GameObject) Instantiate (damageText, other.transform.position, Quaternion.Euler(Vector3.zero));
			clone.GetComponent<FloatingNumbers> ().damageNumber = damageToGive;

			if(other.gameObject.GetComponent<DustMiteController> () != null)
			other.gameObject.GetComponent<DustMiteController> ().StartKnockBack ();
		}
	}


}
