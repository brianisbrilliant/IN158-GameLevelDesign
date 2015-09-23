using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

	public int playerHealth= 100; // current player health

	int playerDamaged= 8; //Did the player take damage



	IEnumerator PlayerDamaged(){
		int hurtPlayer = playerHealth - playerDamaged;  //Damage done to the player
		Debug.Log(hurtPlayer);
		playerHealth = hurtPlayer;
		yield return new WaitForSeconds(1);

				//Display the player health

	}

	void Start () {
		Debug.Log(playerHealth);
	}

	// Update is called once per frame
	void Update () {
		if (Input.anyKey){		//Method ran when player presses key to cause damage
			PlayerDamaged();
		}


	}

}
