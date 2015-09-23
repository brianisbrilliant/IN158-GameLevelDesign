using UnityEngine;
using System.Collections;

public class LearningScript : MonoBehaviour {

	Helicopter controls;
	
	void Start () 
	{
		controls = GameObject.Find("Cube").GetComponent<Helicopter>();
		Debug.Log(controls);
	}
	
	void Update () 
	{
		if(Input.GetKey(KeyCode.LeftArrow))
			controls.GetComponent<Helicopter>().StrafeLeft();
		if(Input.GetKey(KeyCode.RightArrow))
			controls.GetComponent<Helicopter>().StrafeRight();
		
		if(Input.GetKey(KeyCode.UpArrow))
			controls.VerticalUp();
		if(Input.GetKey(KeyCode.DownArrow))
			controls.VerticalDown();
		
		if(Input.GetKey(KeyCode.R)) 
			controls.RotateClockWise();
		if(Input.GetKey(KeyCode.L)) 
			controls.RotateCounterClockWise();
/*		
		if(Input.GetKey(KeyCode.F)) 
			controls.RotateBackward();
		if(Input.GetKey(KeyCode.B)) 
			controls.RotateForward();
		
		if(Input.GetKey(KeyCode.Y)) 
			controls.RotateYp();
		if(Input.GetKey(KeyCode.M)) 
			controls.RotateYm();
*/		
	}
}
