using UnityEngine;
using System.Collections.Generic;

public class Dictionary : MonoBehaviour {

	public Dictionary<int,string> cleverPhrases = new Dictionary<int,string>(){
		{1,"Give a man a match, and he'll be warm for a minute, but set him on fire, and he'll be warm for the rest of his life."},
		{2,"The real trouble with reality is that there's no background music."},
		{3,"Going to church doesn't make you a Christian any more than standing in a garage makes you a car."},
		{4,"Everyone is entitled to be stupid, but some abuse the privilege"},
		{5,"War doesn't determine who's right. War determines who's left."}
	};
		
	// Use this for initialization
	void Start () {
		Debug.Log("Enter a number between 1 and 5 at the top of your keyboard to see a clever phrase, or enter 0 to see all 5.");
	}
	
	// Update is called once per frame
	void Update () {
		
		foreach(KeyValuePair<int,string> phrase in cleverPhrases){
			if(Input.GetKeyDown(KeyCode.Alpha0)){
				Debug.Log(phrase.Value);
			} else
			if(Input.GetKeyDown(KeyCode.Alpha1)){
				if(phrase.Key == 1){
					Debug.Log(phrase.Value);
				}
			} else
			if(Input.GetKeyDown(KeyCode.Alpha2)){
				if(phrase.Key == 2){
					Debug.Log(phrase.Value);
				}
			} else 
			if(Input.GetKeyDown(KeyCode.Alpha3)){
				if(phrase.Key == 3){
					Debug.Log(phrase.Value);
				}
			} else
			if(Input.GetKeyDown(KeyCode.Alpha4)){
				if(phrase.Key == 4){
					Debug.Log(phrase.Value);
				}
			} else
			if(Input.GetKeyDown(KeyCode.Alpha5)){
				if(phrase.Key == 5){
					Debug.Log(phrase.Value);
				}
			} 
		}
		//cleverPhrases.ToList().ForEach(x => Console.WriteLine(x.Key));
		
	}
}

/*
1. make a List or Dictionary of clever phrases,
2. make if statements for numbers 1-5
          if(Input.GetKeyDown(KeyCode.Alpha1)) {
               Debug.Log(phrases[0]);
          }
3. finally, use a foreach, for, or a while loop, 
     to list all phrases in your list.
          foreach(string phrase in phrases)
               debug.log(phrase);
*/
