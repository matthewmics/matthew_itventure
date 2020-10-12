using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameTagAssign : MonoBehaviour {
	public string objectName;
	public Text displayText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		displayText.text = objectName;
		transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z);
	}
}
