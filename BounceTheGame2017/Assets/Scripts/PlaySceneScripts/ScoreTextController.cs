using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTextController : MonoBehaviour {
	public Text scoreText;
	public Text highScoreText;

	// Use this for initialization
	void OnLevelWasLoaded () {
		ScoreCounter.ResetScore (scoreText);
		UpdateScore ();
		UpdateHighScore ();
	}


	// Update is called once per frame
	void UpdateScore () {
		scoreText.text = "Score: " + ScoreCounter.GetScore ();
	}

	void UpdateHighScore(){
		highScoreText.text = "High Score: " + ScoreCounter.GetHighScore ();
	}
}
