using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class ScoreCounter {

	static int score = 0;
	static int highScore = 0;


	// Update is called once per frame
	public static void IncreaseScore (Text scoreText, Text highScoreText) {
		score++;
		scoreText.text = "Score: " + score;
		if (GetHighScore () < score) {
			SetHighScore (score, highScoreText);
		}
	}

	public static int GetScore(){
		return score;
	}

	static void SetScore(int newScore){
		score = newScore;
	}	

	public static int GetHighScore(){
		return highScore;
	}

	static void SetHighScore(int newHighScore, Text highScoreText){
		highScore = newHighScore;
		highScoreText.text = "High Score: " + highScore;
	}

	public static void ResetScore(Text scoreText){
		score = 0;
		scoreText.text = "Score: " + score;
	}
}
