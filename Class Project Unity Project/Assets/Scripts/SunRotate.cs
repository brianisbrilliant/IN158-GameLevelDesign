using UnityEngine;
using System.Collections;

public class SunRotate : MonoBehaviour {

	public int rotSpeed = 5;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(rotSpeed * Time.deltaTime,0,0);
	}
}
