using UnityEngine;
using System.Collections;

public class ShadowObject : MonoBehaviour {

	public GameObject player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.position = player.transform.position;
		//transform.rotation.eulerAngles  = new Vector3(0.0f, 0.0f, 0.0f);
	}
}
