using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour {

	public GameObject player;
	private Vector3 Offset;
	// Use this for initialization
	void Start () {
		Offset = transform.position;
		Input.compass.enabled = true;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = player.transform.position + Offset;
		transform.localRotation.Set (0.0f, Input.compass.trueHeading/360.0f, 0.0f, 0.0f);
	}
}
