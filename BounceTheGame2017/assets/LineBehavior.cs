using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineBehavior : MonoBehaviour {
	public GameObject line;

	void OnCollisionEnter ( Collision collision){
		Debug.Log ("Collided");
		line.SetActive (false);
	}
}
