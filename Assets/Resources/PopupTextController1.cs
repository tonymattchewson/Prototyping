using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupTextController1 : MonoBehaviour {
	private static FloatingText popupTextPrefab;
	private static GameObject canvas;

	public static void Initialize(){
		canvas = GameObject.Find("CanvasPlayer");
		if (!popupTextPrefab) 
		popupTextPrefab = Resources.Load<FloatingText> ("PopupTextParent");
	}

	public static void CreateFloatingText(string text, Transform location){
		FloatingText instance = Instantiate (popupTextPrefab);
		instance.transform.SetParent(canvas.transform, false );
		instance.SetText (text);
	}
}
