using UnityEngine;
using System.Collections;

public class CompassAction : MonoBehaviour {
	public GameObject camera;

	private Vector3 Offset;
	private float oldHdng;
	// Use this for initialization
	void Start () {
		Offset = transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = camera.transform.position + Offset;
		float newHeading = Input.compass.trueHeading;
		if ((oldHdng - newHeading) > 3.0f || (oldHdng - newHeading) < -3.0f)
			oldHdng = newHeading;
		
		transform.eulerAngles = new Vector3(0.0f, oldHdng, 0.0f);
	

	}
}
