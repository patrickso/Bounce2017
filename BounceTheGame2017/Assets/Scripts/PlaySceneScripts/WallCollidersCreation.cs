using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollidersCreation : MonoBehaviour {
	public BoxCollider2D wallCollider;


	Vector3 GetFloorPosition(){
		Vector3 floorPosition = new Vector3 (Screen.width/2,0, 0);
		floorPosition = Camera.main.ScreenToWorldPoint (floorPosition);
		floorPosition.z = 0;
		floorPosition.y = floorPosition.y - (float).5;
		return floorPosition;
	}

	Vector3 GetLeftWallPosition(){
		Vector3 leftWallPosition = new Vector3 (0,(Screen.height*10)/2, 0);
		leftWallPosition = Camera.main.ScreenToWorldPoint (leftWallPosition);
		leftWallPosition.x = leftWallPosition.x - (float).5;
		leftWallPosition.z = 0;
		return leftWallPosition;
	}

	Vector3 GetRightWallPosition(){
		Vector3 rightWallPosition = new Vector3 (Screen.width,(Screen.height*10)/2, 0);
		rightWallPosition = Camera.main.ScreenToWorldPoint (rightWallPosition);
		rightWallPosition.z = 0;
		rightWallPosition.x = rightWallPosition.x + (float).5;
		return rightWallPosition;
	}

	void InstantiateFloor(){
		Vector3 position = GetFloorPosition ();
		BoxCollider2D floor = Instantiate (wallCollider, position, transform.rotation);
		floor.size = new Vector2 (Utils.PixelsToUnits(Screen.width), 1);
	}

	void InstantiateLeftWall(){
		Vector3 position = GetLeftWallPosition ();
		BoxCollider2D leftWall = Instantiate (wallCollider, position, transform.rotation);
		leftWall.size = new Vector2 (1, Utils.PixelsToUnits(Screen.height) * 10);
	}

	void InstantiateRightWall(){
		Vector3 position = GetRightWallPosition ();
		BoxCollider2D rightWall = Instantiate (wallCollider, position, transform.rotation);
		rightWall.size = new Vector2 (1, Utils.PixelsToUnits(Screen.height)*10);
	}

	void Start () {
		InstantiateFloor ();
		InstantiateLeftWall ();
		InstantiateRightWall ();
	}

}
