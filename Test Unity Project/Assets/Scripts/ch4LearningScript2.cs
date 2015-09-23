using UnityEngine;
using System.Collections;

public class ch4LearningScript2 : MonoBehaviour {

	// these variables are in scope for the whole method, but cannot be used outside of this method.
	// you would have to call this method to use them.
	int num1 = 2;
	int num2 = 3;
	int num3 = 7;

	// Use this for initialization
	void Start () 
	{
		// because this is inside Start(), this code will be executed as soon as i hit Play.
		//  this code is calling AddTwoNumbers() twice, and adding the sum from both of them. 
		// DisplaySum() is outputting the value to the Debug.Log
		int sum = AddTwoNumbers(num1, num2) + AddTwoNumbers(num1, num3);

		DisplaySum(sum);
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	int AddTwoNumbers(int firstNum, int secondNum) 
	{
		int sum = firstNum + secondNum;
		return sum;
	}

	void DisplaySum(int total) {
		Debug.Log("The grand total is: " + total);
	}

}