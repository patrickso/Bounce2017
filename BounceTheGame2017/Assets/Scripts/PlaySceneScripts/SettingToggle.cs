using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingToggle : MonoBehaviour {

	int count;
	public GameObject settingsMenu;

	void Start(){
		count = 1;
	}

	public void ToggleSettingsMenu(){
		bool menuStatus = settingsMenu.activeSelf;
		settingsMenu.SetActive (menuStatus);
		Debug.Log ("Clicked Settings: " + count);
		count++;
	}
}
