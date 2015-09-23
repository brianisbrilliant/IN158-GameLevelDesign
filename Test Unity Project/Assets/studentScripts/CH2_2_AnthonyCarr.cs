using UnityEngine;
using System.Collections;

public class CH2_2_AnthonyCarr : MonoBehaviour {
	//These are my Variables
	//They in a public class so i can edit them in the inspector
	//Brian is the best teacher in the world
	//I am a kiss ass
	//LOL
	// the int is what type this var will return
	public int myNumberOfTacos = 9;
	public int moreTacos = 1;
	// Use this for initialization
	void Start () {
				Debug.Log (2 + 9);
		// This Sends a debug message to Unity
				Debug.Log (11 + myNumberOfTacos);

		}
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.Return)) 
		{
			//This is my funtion
			//It will add Tacos to my Number of Tacos Var

						AddTwoTacos ();
		}
	}
	//This is what the funtion will do when called
	// the += is so that it will return the number it creates and add more and more each time i press the enter key
	void AddTwoTacos()
	{
		//Debug.Log (moreTacos += myNumberOfTacos);
		Debug.Log (myNumberOfTacos += moreTacos);
	}

}
