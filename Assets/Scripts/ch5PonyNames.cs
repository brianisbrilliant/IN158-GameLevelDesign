using UnityEngine;
using System.Collections.Generic;		//added Generic, idk why.

public class ch5PonyNames : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// well shit, i am not going to make a list of fucking pony names. god i hate this guy.
		List<string> myFavPpl = new List<string>();

		myFavPpl.Add("Mahatma Gandhi");
		myFavPpl.Add("Steve Jobs");
		myFavPpl.Add("Joss Whedon");

		Debug.Log("This list has " + myFavPpl.Count + " names in it.");

		Debug.Log(myFavPpl[1] + " is the second person on the list.");
		Debug.Log(myFavPpl[2] + " is the third person on the list.");
		Debug.Log(myFavPpl[0] + " is the first person on the list.");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
