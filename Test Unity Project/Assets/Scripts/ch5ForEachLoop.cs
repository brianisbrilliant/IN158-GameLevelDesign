using UnityEngine;
using System.Collections.Generic;

public class ch5ForEachLoop : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		// this is an array
		string[] linkItems = new string[]
			{"MasterSword", "Boomerang"};

		foreach(string item in linkItems) {
			if(item == "Boomerang")
				Debug.Log("You've found the " + item + "!");
		}
		
		// this is a list
		List<string> characterList = new List<string>()
			{"Tingle", "Epona"};

		foreach(string person in characterList) {
			if(person == "Tingle")
				Debug.Log("I was looking for " + person + ".");
		}
		
		// this is a dictionary
		Dictionary<int, string> levelsDictionary = new Dictionary<int, string>()
			{{10, "Dodongo's Cavern"}, {20, "Lon Lon Ranch"}};

		foreach(KeyValuePair<int, string> level in levelsDictionary) {
			if(level.Key == 20)
				Debug.Log("I was looking for " + level.Value +".");
		} 
	}
}

/*
	so, in the array, we're creating an array and initializing it with 
	two items. then we walk through the list until we find the item we're
	looking for, in this case the "Boomerang". the script should then output 
	to the debug log "i was looking for Boomerang."

	in the list, we do the same thing. initialize with 2 people, iterate 
	through the list until we find the person we're looking for, then 
	output to the debug log "i was looking for Tingle"

	in the dictionary, same thing, initialize with 2 levels, iterate through
	the Dictionary until you find the level you're looking for, output to the
	log "I was looking for Lon Lon Ranch."
*/
