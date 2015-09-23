using UnityEngine;
using System.Collections;

public class ch5AndOrOperators : MonoBehaviour {
		public bool playerIsAlive = true;
		public int temp = 40;
	// Use this for initialization
	void Start () {


		if(temp >= 35 && playerIsAlive) {
			Debug.Log("Both conditions have been met.");
		}

		if(temp >= 35 || playerIsAlive) {
			Debug.Log("At least one of the conditions have been met.");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
