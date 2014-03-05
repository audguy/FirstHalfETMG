using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour {

	public GameObject player;
	private Vector3 Offset;
	// Use this for initialization
	void Start () {
		Offset = transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = player.transform.position + Offset;
	}
}
