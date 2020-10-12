using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevelManager : MonoBehaviour {

	public GameObject nextMap;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void unlockNextLevel(){
		nextMap.SetActive (true);
	}
}
