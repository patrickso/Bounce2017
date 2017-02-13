using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LineCreation : MonoBehaviour {

	public Rigidbody2D line;
	Vector3 startPos;
	bool clicked = false;
	public Camera camera;
	Rigidbody2D workingLine;


	Vector3 GetTouchCoordinates(){
		Vector3 returnPosition = camera.ScreenToWorldPoint(Input.mousePosition);
		returnPosition.z = 0;
		return returnPosition;
	}

	bool IsTouchDown(){
		return Input.GetMouseButton (0);
	}

	void DrawLine(Vector3 start, Vector3 end)
	{
		workingLine = (Rigidbody2D) Instantiate(line, transform.position, transform.rotation);
		LineRenderer renderer = workingLine.GetComponent<LineRenderer> ();
		var positions = new Vector3[2];
		positions [0] = start;
		positions [1] = end;


		renderer.SetPositions (positions);

		
	}

	void FinalizeWorkingLine(){
		LineRenderer renderer = workingLine.GetComponent<LineRenderer> ();
		PolygonCollider2D collider = workingLine.GetComponent<PolygonCollider2D> ();
		collider.isTrigger = false;

		PhysicsMaterial2D bounceMaterial = new PhysicsMaterial2D ();

		var start = renderer.GetPosition (0);
		var end = renderer.GetPosition (1);
		Debug.Log ((end - start).magnitude);
		float length = ((end - start).magnitude) / Utils.PixelsToUnits(Screen.width);
		Debug.Log (length);
		bounceMaterial.bounciness = (float) (3.0 * Mathf.Exp((float) -2.2 * length));
		Debug.Log (bounceMaterial.bounciness);
		collider.sharedMaterial = bounceMaterial;

		renderer.startColor = Color.black;
		renderer.endColor = Color.black;
	}

	void UpdateWorkingLine(Vector3 start, Vector3 end){
		LineRenderer renderer = workingLine.GetComponent<LineRenderer> ();
		PolygonCollider2D collider = workingLine.GetComponent<PolygonCollider2D> ();

		var positions = new Vector3[2];
		positions [0] = start;
		positions [1] = end;
		renderer.SetPositions (positions);
		var colliderPoints = new Vector2[4];

		float slope = (float)(end.y - start.y) / (end.x - start.x);
		float b = start.y - (slope * start.x);
		float theta = Mathf.Atan (slope);
		float phi = (float)(.5 * 3.14159) - theta;
		float dx = (float).75 * Mathf.Cos (phi);
		float dy = (float).75 * Mathf.Sin (phi);


		colliderPoints [0] = new Vector2 (start.x + dx, start.y - dy);
		colliderPoints [1] = new Vector2 (start.x - dx, start.y + dy);
		colliderPoints [2] = new Vector2 (end.x -dx, end.y +dy);
		colliderPoints [3] = new Vector2 (end.x +dx, end.y -dy);
		collider.SetPath (0, colliderPoints);
	}

	// Update is called once per frame
	void LateUpdate () {
		Vector3 pos = GetTouchCoordinates ();
		if (IsTouchDown ()) {
			if (clicked) {
				UpdateWorkingLine(startPos, pos);

			} else {
				startPos = pos;
				clicked = true;
				DrawLine (startPos, pos);
			}

		} else {
			if (clicked) {
				FinalizeWorkingLine ();
				clicked = false;
			}
		}
	}

}
