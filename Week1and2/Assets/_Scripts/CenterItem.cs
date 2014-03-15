using UnityEngine;
using System.Collections;

public class CenterItem : MonoBehaviour {

	public GUIText textToCenter;
	// Use this for initialization
	void Start () {

		Vector2 offset = new Vector2 (Screen.width*.5f,Screen.height*.5f);
		textToCenter.pixelOffset = offset;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
