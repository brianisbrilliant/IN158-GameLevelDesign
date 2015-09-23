using UnityEngine;
using System.Collections;

public class learningScript : MonoBehaviour {		// the class "learningScript" is inheriting the member functions of "Monobehaviour"
	public int numberOne = 2;					// changed from public to private
	public int numberTwo = 9;					// removed the keyword 'public'
	public bool theBigUglyRobotIsStillCute = true;
	public float pi = 3.14f;		//this f at the end is necessary.
	public string  someWords = "Hello World.";

	public string block1 = "This is a Global Variable, visible everywhere.";
	// Use this for initialization
	// this is one of MonoBehaviours methods
	void Start () {			//------------------------------CODE BLOCK 1----------------------
		Debug.Log(block1);
		string block2 = "This is a local variable, visible when Start() is running.";
		Debug.Log(block2);
		{		//----------------------------CODE BLOCK 2------------------------
			Debug.Log(block1);
			Debug.Log(block2);
			string block3 = "This is a local variable, only existing inside the {} of a potion of Start()";
			Debug.Log(block3);
		}		//-----------------------END OF CODE BLOCK 2-----------------------

		// block3 is out of scope and hidden from view.
		// Debug.Log(block3);		// will throw an error
	}		//--------------------------END of CODE BLOCK 1------------------------------------

	// Update is called once per frame
	// this is another of MonoBehaviours methods
	void Update () {
		if(Input.GetKeyUp(KeyCode.Return))
			AddTwoNumbers();
	}

	// we cooked up this method all on our own!
	void AddTwoNumbers() {
		Debug.Log(numberOne + numberTwo);
	}
}
