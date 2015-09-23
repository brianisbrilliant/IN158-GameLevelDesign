using UnityEngine;
using System.Collections.Generic;

public class ch5_Dictionary : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Dictionary<int, string> myFavMovies = new Dictionary<int, string>();

		myFavMovies.Add(10, "Eternal Sunshine of the Spotless Mind");
		myFavMovies.Add(20, "Star Wars");
		myFavMovies[30] = "The Hobbit";

		Debug.Log("The movie for key 10 is " + myFavMovies[10]);
		Debug.Log("The movie for key 20 is " + myFavMovies[20]);
		Debug.Log("The movie for key 30 is " + myFavMovies[30]);

		myFavMovies[35] = "Donnie Darko";

		Debug.Log("The 4th movie is " + myFavMovies[35]);

		Debug.Log("This Dictionary has " + myFavMovies.Count + " movies.");	
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
