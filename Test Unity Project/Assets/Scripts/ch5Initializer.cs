using UnityEngine;
using System.Collections.Generic;

public class ch5Initializer : MonoBehaviour 
{
	// Use this for initialization
	void Start () 
	{
		List<string> myFavBooks = new List<string>()
			{"Harry Potter", "Star Wars"};

		Debug.Log("Book 1 is " + myFavBooks[0]);
		Debug.Log("Book 2 is " + myFavBooks[1]);

		Dictionary<int, string> myFavGames = new Dictionary<int, string>()
			{{10, "HL2"},{20, "Portal"}};

		Debug.Log("game 1 " + myFavGames[0]);
		Debug.Log("game 2 is " + myFavGames[1]);
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
