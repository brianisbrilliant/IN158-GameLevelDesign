using UnityEngine;
using System.Collections;

public class ch5IfElseStatement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		bool isAuthorAlive = false;

		if(isAuthorAlive) {
			Debug.Log("This is executed because the condition is true.");
		}
		else {
			Debug.Log("This is executed because the condition is false.");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
