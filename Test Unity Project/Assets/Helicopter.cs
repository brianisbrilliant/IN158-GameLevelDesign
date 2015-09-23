using UnityEngine;
using System.Collections;

public class Helicopter : MonoBehaviour {
public float speedX = 10, speedY = 5, speedZ = 5;

	public void StrafeLeft(){
		if ( (transform.eulerAngles.z >= 0f && transform.eulerAngles.z <= 30f) 
											||
			(transform.eulerAngles.z >= 330f && transform.eulerAngles.z <= 360f) )
		{
			transform.Rotate(0,0,speedX * 10 * Time.deltaTime);
		}
		transform.position -= new Vector3(speedX * Time.deltaTime, 0, 0);
	}
	public void StrafeRight(){
		if ( (transform.eulerAngles.z >= 0f && transform.eulerAngles.z <= 30f) 
											||
			(transform.eulerAngles.z >= 330f && transform.eulerAngles.z <= 360f) )
		{
			transform.Rotate(0,0,-speedX * 10 * Time.deltaTime);
		}
		transform.position += new Vector3(speedX * Time.deltaTime, 0, 0);
	}
	public void VerticalDown(){
		transform.position -= new Vector3(0, speedY * Time.deltaTime, 0);
	}
	public void VerticalUp(){
		transform.position += new Vector3(0, speedY * Time.deltaTime, 0);
	}
	public void RotateCounterClockWise(){
		transform.Rotate(0,-speedY * 10 * Time.deltaTime,0);
	}
	public void RotateClockWise(){
		transform.Rotate(0,speedY * 10 * Time.deltaTime,0);
	}
/*	public void RotateForward(){ // Forward when X & Y are 0
		transform.Rotate(-speedX * 10 * Time.deltaTime,0,0);
	}
	public void RotateBackward(){ // Backward when X & Y are 0
		transform.Rotate(speedX * 10 * Time.deltaTime,0,0);
	}
	public void RotateYm(){ // Y-axis minus
		transform.Rotate(0,0,-speedX * 10 * Time.deltaTime);
	}
	public void RotateYp(){ // Y-axis plus
		transform.Rotate(0,0,speedX * 10 * Time.deltaTime);
	}
*/
}
