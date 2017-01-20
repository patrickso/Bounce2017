using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class navigation_script : MonoBehaviour {

	// Use this for initialization
	public void startPlay() {
		SceneManager.LoadScene ("PlayScene");
	}

	public void startMain(){
		SceneManager.LoadScene ("MainScene");
	}
}
