using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Game{

	public static Game current;
	public bool[] progress;
	public bool[] wepunlocked;
	public Game () {
		progress = new bool[5];
		wepunlocked = new bool[]{true,false,false};
	}
		
}
