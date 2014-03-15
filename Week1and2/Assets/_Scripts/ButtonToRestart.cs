using UnityEngine;
using System.Collections;

public class ButtonToRestart : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI () {
		if (GUI.Button (new Rect (Screen.width * 0.25f, Screen.height * 0.6f,Screen.width * 0.5f,Screen.height * 0.25f), "Restart")) {
			Application.LoadLevel ("Title");
		}
	}
}
