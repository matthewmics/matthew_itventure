using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MegaBoardController : MonoBehaviour {

	private Rigidbody2D thisRB;
	public float timeToMove;
	public float timeBetween;
	private float timeToMoveC;
	private float timeBetweenC;
	public int moveSpeed;

	public float timeToAttack;
	private float timeToAttackC;
	public float timeBetweenAttack;
	private float timeBetweenAttackC;


	private Vector2 moveDirection;
	private bool moving;
	public string EnemyName;

	private GameObject thePlayer;
	public GameObject nameTag;
	public float tagYAdjust;

	// Use this for initialization
	void Start(){
		thisRB = GetComponent<Rigidbody2D> ();



		var tag = (GameObject) Instantiate (nameTag, new Vector3(gameObject.transform.position.x,gameObject.transform.position.y - tagYAdjust, gameObject.transform.position.z), Quaternion.Euler(Vector3.zero));
		Transform t = nameTag.transform;

		//var tag = (GameObject) Instantiate (nameTag,gameObject.transform);	
		tag.transform.SetParent (gameObject.transform, true);
		tag.transform.localPosition = new Vector3 (
			0.0f,
			0-tagYAdjust,
			0.0f
		);

		//tag.transform.localPosition = new Vector3 (0.0f,0-tagYAdjust,0.0f));
		//tag.transform.SetParent(gameObject.transform,false);
		tag.GetComponent<NameTagAssign> ().objectName = EnemyName;

		timeBetweenC = Random.Range (timeBetween * 0.75f, timeBetween * 1.25f);
		timeToMoveC = Random.Range (timeToMove * 0.75f, timeToMove * 1.25f);

	}
	
	// Update is called once per frame
	void Update () {

			if (moving) {
				timeToMoveC -= Time.deltaTime;
				thisRB.velocity = moveDirection;
				if (timeToMoveC < 0f) {
					moving = false;
					timeBetweenC = Random.Range (timeBetween * 0.75f, timeBetween * 1.25f);
				}
			} else {
				timeBetweenC -= Time.deltaTime;
				thisRB.velocity = Vector2.zero;
				if (timeBetweenC < 0f) {
					moving = true;
					timeToMoveC = Random.Range (timeToMove * 0.75f, timeBetween * 1.25f);
					moveDirection = new Vector3 (Random.Range (-1f, 1f) * moveSpeed, Random.Range (-1f, 1f) * moveSpeed, 0f);
				}
			}
	}
	void OnCollisionEnter2D (Collision2D other)
	{
//		if (other.gameObject.name == "Player")
//		{
//			//Destroy (other.gameObject);
//			other.gameObject.SetActive (false);
//			reloading = true;
//			thePlayer = other.gameObject;
//		}
	}
}
