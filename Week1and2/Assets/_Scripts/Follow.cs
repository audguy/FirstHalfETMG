using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour {

	public GameObject player;
	public GUIText valu;
	private Vector3 Offset;
	private float oldHdng;
	// Use this for initialization
	void Start () {
		Offset = transform.position;
		Input.compass.enabled = true;
		oldHdng = 0.0f;
	}
	
	// Update is called once per frame
	void LateUpdate () {

		transform.position = player.transform.position + Offset;

	}
}
