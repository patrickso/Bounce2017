using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LineCreation : MonoBehaviour {
	Vector3 startPos;
	bool clicked = false;


	Vector3 GetTouchCoordinates(){
		return Input.mousePosition;
	}

	bool IsTouchDown(){
		return Input.GetMouseButtonDown (0);
	}

	void DrawLine(Vector3 start, Vector3 end)
	{
		GameObject myLine = new GameObject();
		myLine.transform.position = start;
		myLine.AddComponent<LineRenderer>();
		LineRenderer lr = myLine.GetComponent<LineRenderer>();
		lr.material = new Material(Shader.Find("Standard"));
		lr.material.color = Color.black;
		lr.SetColors(Color.black, Color.black);
		lr.SetWidth(0.5f, 0.5f);
		lr.SetPosition(0, start);
		lr.SetPosition(1, end);
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = GetTouchCoordinates ();

		Text xcoor_text = GameObject.Find("X-Coor").GetComponent<Text> ();
		xcoor_text.text = "X-coor: " + pos.x;
		Text ycoor_text = GameObject.Find("Y-Coor").GetComponent<Text> ();
		ycoor_text.text = "Y-coor: " + pos.y;
		Text mouse_down = GameObject.Find ("MouseDown").GetComponent<Text> ();
		mouse_down.text = "MouseDown: " + IsTouchDown ();
		if (IsTouchDown ()) {
			if (clicked) {
				Debug.Log ("Drawing line");
				//DrawLine (new Vector3 (0, 0), pos);
				DrawLine (startPos, pos);
			} else {
				startPos = pos;
			}
			clicked = !clicked;
		}
	}
}
