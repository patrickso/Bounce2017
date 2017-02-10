using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineBehavior : MonoBehaviour {
	public GameObject line;


	void OnCollisionEnter2D ( Collision2D collision){
		if (collision.gameObject.tag == "Green Tomato") {
			Destroy (line);
		}

	}
}
