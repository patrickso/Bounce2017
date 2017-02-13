using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TomatoCreation : MonoBehaviour {

	public Rigidbody2D tomato;

	Vector3 GetTomatoStartingPosition(){
		float randomWidth = Random.Range (0, Screen.width);
		Vector3 returnPosition = new Vector3(randomWidth, Screen.height, 0);
		returnPosition = Camera.main.ScreenToWorldPoint(returnPosition);
		returnPosition.z = 0;
		return returnPosition;
	}
		
	void CreateTomato(){
		Vector3 tomatoPosition = GetTomatoStartingPosition ();
		Rigidbody2D workingTomato = (Rigidbody2D) Instantiate(tomato, tomatoPosition, transform.rotation);
		workingTomato.MovePosition (tomatoPosition);
	}
	void Start () {
		CreateTomato ();

	}

}
