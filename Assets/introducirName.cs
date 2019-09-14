using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class introducirName : MonoBehaviour {

	private string nombre = "";
	void OnGUI()
	{
		//GUI.contentColor = Color.white;
		//nombre = GUI.TextField (new Rect (219, 100, 100, 20), nombre, 11);
		//GUI.contentColor = Color.yellow;
		//if (GUI.Button (new Rect (220, 130, 100, 30), "Introducir")) 
		//{
			PlayerPrefs.SetString ("nombre", nombre);
		//	Application.LoadLevel(3);
		//}
	}
}
