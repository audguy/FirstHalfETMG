using UnityEngine;
using System.Collections;

public class ButtonToGo : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update()
	{
		camera.transform.Rotate (0f, 1f * Time.deltaTime, 0f);
	}
	void OnGUI () {
		if (GUI.Button (new Rect (Screen.width * 0.25f, Screen.height * 0.6f,Screen.width * 0.5f,Screen.height * 0.25f), "Play!")) {
						Application.LoadLevel ("Playfield");
				}
	}
}
