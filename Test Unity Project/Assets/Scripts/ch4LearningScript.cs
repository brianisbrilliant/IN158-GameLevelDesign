using UnityEngine;
using System.Collections;

public class ch4LearningScript : MonoBehaviour {

	// these variables are in scope for the whole method, but cannot be used outside of this method.
	// you would have to call this method to use them.
	int num1 = 2;
	int num2 = 3;
	int num3 = 7;

	// Use this for initialization
	void Start () 
	{
		// because this is inside Start(), this code will be executed as soon as i hit Play.
		AddTwoNummbers(num1, num2);
		AddTwoNummbers(num1, num3);
		AddTwoNummbers(num2, num3);
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void AddTwoNummbers(int firstNum, int secondNum) 
	{
		int sum = firstNum + secondNum;
		Debug.Log(sum);
	}
}