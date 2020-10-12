using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bg_scroll : MonoBehaviour {

	// Use this for initialization
	public float speed = 0.1f;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 offset = new Vector2 (Time.time * speed, 0f);
		//GetComponent<Renderer> ().material.mainTextureOffset = offset;
		GetComponent<RawImage> ().material.SetTextureOffset("_MainTex", offset);
	}
}
