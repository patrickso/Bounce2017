using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LineBehavior : MonoBehaviour {
	public GameObject line;
	public Text scoreText;
	public Text highScoreText;

	void Start(){
		scoreText = GameObject.Find ("Score Text").GetComponent<Text>();
		highScoreText = GameObject.Find ("High Score Text").GetComponent<Text>();
	}

	void OnCollisionEnter2D ( Collision2D collision){
		if (collision.gameObject.tag == "Green Tomato") {
			Destroy (line);
			ScoreCounter.IncreaseScore (scoreText, highScoreText);
		}

	}
}
