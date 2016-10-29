using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public static int playerSpeed = 10; //Initilize player speed

	
	
	void FixedUpdate () {
        gameObject.transform.Translate(Vector3.right * playerSpeed * Time.deltaTime); // has the player move to the right every second

	}
}
