using UnityEngine;
using System.Collections;

public class Ch5IfStatements : MonoBehaviour {

	// Use this for initialization
	void Start () {
		bool authorKilled = true;

		if(authorKilled) {
			Debug.Log("Bang! The witch is dead!");
		}

		authorKilled = false;

		if(!authorKilled) {
			Debug.Log("God, that's a shame. Maybe someday!");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
