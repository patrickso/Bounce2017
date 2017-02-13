using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utils {

	public static float PixelsToUnits(float pixelNum){
		float PXPerUnit = Screen.height / (2 * Camera.main.orthographicSize);
		return pixelNum / PXPerUnit;
	}

}
