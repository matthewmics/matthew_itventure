﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	// Use this for initialization
	public GameObject followTarget;
	private Vector3 targetPos;
	public float moveSpeed;
	public static bool cameraExists;
	public BoxCollider2D boundBox;

	private Camera theCamera;
	private Vector3 minBounds;
	private Vector3 maxBounds;
	private float halfHeight;
	private float halfWidth;

	void Start () {
		if (!cameraExists) {
			cameraExists = true;
			DontDestroyOnLoad (transform.gameObject);
		} else {

			Destroy (gameObject);
		}

		minBounds = boundBox.bounds.min;
		maxBounds = boundBox.bounds.max;

		theCamera = GetComponent<Camera> ();
		halfHeight = theCamera.orthographicSize;
		halfWidth = halfHeight * Screen.width / Screen.height; 
	}
	
	// Update is called once per frame
	void Update () {
		if (followTarget == null) {
			followTarget = GameObject.FindGameObjectWithTag ("Player");
		}
		targetPos = new Vector3 (followTarget.transform.position.x, followTarget.transform.position.y, transform.position.z);
		transform.position = Vector3.Lerp (transform.position, targetPos, moveSpeed*Time.deltaTime);
		if (boundBox == null) {
			boundBox = FindObjectOfType<Bounds> ().GetComponent<BoxCollider2D>();
			minBounds = boundBox.bounds.min;
			maxBounds = boundBox.bounds.max;
		}
		float clampedX = Mathf.Clamp (transform.position.x, minBounds.x + halfWidth, maxBounds.x - halfWidth);
		float clampedY = Mathf.Clamp (transform.position.y, minBounds.y + halfHeight, maxBounds.y - halfHeight);
		transform.position = new Vector3 (clampedX, clampedY, transform.position.z);
	}
	public void SetBounds(BoxCollider2D newBounds){
		boundBox = newBounds;

		minBounds = boundBox.bounds.min;
		maxBounds = boundBox.bounds.max;
	}
}
