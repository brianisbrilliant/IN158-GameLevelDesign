using UnityEngine;
using System.Collections;

public class EnumTest : MonoBehaviour {
	enum Chars {Han, Luke, Leia, Chewie, R2D2, Threepio};
	// Use this for initialization
	void Start () {
		Chars myChar = Chars.Leia;		// what is the point of an enum??
										// if i can't use the numbers.

		Debug.Log(this);
		Debug.Log(myChar);
	}

	// Update is called once per frame
	void Update () {

	}
}
