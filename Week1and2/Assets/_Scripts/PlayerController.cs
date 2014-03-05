using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float Scale=10;
	void Update()
	{/*
		Vector3 acceleration = Vector3.zero;
		int i = 0;
		while (i < Input.accelerationEventCount) {
			AccelerationEvent accEvent = Input.GetAccelerationEvent(i);
			acceleration += accEvent.acceleration * accEvent.deltaTime;
			++i;
		}
		//float moveH = Input.GetAxis ("Horizontal");
		//float moveV = Input.GetAxis ("Vertical");
		Vector3 scl = new Vector3 (Scale, Scale, Scale);

		//acceleration.y = 0.0f;
		//rigidbody.AddForce (acceleration *Scale,ForceMode.VelocityChange);
		rigidbody.AddTorque (acceleration*Scale,ForceMode.VelocityChange);
		*/
		float mH = Input.GetAxis ("Horizontal");
		float mV = Input.GetAxis ("Vertical");

		Vector3 vec3 = new Vector3 (mH, 0.0f, mV);
		rigidbody.AddForce(vec3 * Scale);
	}
}
